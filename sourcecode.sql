-- Drop the database if it exists and create a new one
DROP DATABASE IF EXISTS library_managment_system;
CREATE DATABASE library_managment_system;
USE library_managment_system;

-- Create Authors table
CREATE TABLE Authors (
    AuthorID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DateOfBirth DATE,
    Nationality VARCHAR(50)
);

-- Create Genres tablevw_availablebookssp_SearchUsers
CREATE TABLE Genres (
    GenreID INT AUTO_INCREMENT PRIMARY KEY,
    GenreName VARCHAR(50) NOT NULL UNIQUE
);

-- Create Books table
CREATE TABLE Books (
    BookID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    ISBN VARCHAR(13) NOT NULL UNIQUE,
    PublicationYear INT,
    Description TEXT,
    GenreID INT,
    Quantity INT NOT NULL DEFAULT 1,
    AvailableQuantity INT NOT NULL DEFAULT 1,
    FOREIGN KEY (GenreID) REFERENCES Genres(GenreID)
);

-- Create BookAuthors table (for many-to-many relationship)
CREATE TABLE BookAuthors (
    BookID INT,
    AuthorID INT,
    PRIMARY KEY (BookID, AuthorID),
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

-- Create Users table
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    LibraryCardNumber VARCHAR(20) NOT NULL UNIQUE,
    RegistrationDate DATE NOT NULL,
    IsActive BOOLEAN NOT NULL DEFAULT TRUE
);

-- Create Rentals table
CREATE TABLE Rentals (
    RentalID INT AUTO_INCREMENT PRIMARY KEY,
    BookID INT NOT NULL,
    UserID INT NOT NULL,
    RentalDate DATE NOT NULL,
    DueDate DATE NOT NULL,
    ReturnDate DATE,
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Create Fines table
CREATE TABLE Fines (
    FineID INT AUTO_INCREMENT PRIMARY KEY,
    RentalID INT NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    IsPaid BOOLEAN NOT NULL DEFAULT FALSE,
    FOREIGN KEY (RentalID) REFERENCES Rentals(RentalID)
);

-- Insert sample data for Genres
INSERT INTO Genres (GenreName) VALUES
('Fiction'), ('Non-Fiction'), ('Science Fiction'), ('Mystery'), ('Fantasy');

-- Insert sample data for Authors
INSERT INTO Authors (FirstName, LastName, DateOfBirth, Nationality) VALUES
('J.K.', 'Rowling', '1965-07-31', 'British'),
('George R.R.', 'Martin', '1948-09-20', 'American'),
('Agatha', 'Christie', '1890-09-15', 'British'),
('Stephen', 'King', '1947-09-21', 'American'),
('J.R.R.', 'Tolkien', '1892-01-03', 'British');

-- Insert sample data for Books
INSERT INTO Books (Title, ISBN, PublicationYear, Description, GenreID, Quantity, AvailableQuantity) VALUES
('Harry Potter and the Philosopher''s Stone', '9780747532699', 1997, 'The first book in the Harry Potter series.', 5, 5, 5),
('A Game of Thrones', '9780553103540', 1996, 'The first book in A Song of Ice and Fire series.', 5, 3, 3),
('Murder on the Orient Express', '9780007119318', 1934, 'A famous Hercule Poirot mystery novel.', 4, 2, 2),
('The Shining', '9780385121675', 1977, 'A horror novel about a family staying at a haunted hotel.', 1, 4, 4),
('The Hobbit', '9780261102217', 1937, 'A fantasy novel and prequel to The Lord of the Rings.', 5, 3, 3);

-- Link Books to Authors
INSERT INTO BookAuthors (BookID, AuthorID) VALUES
(1, 1), -- Harry Potter - J.K. Rowling
(2, 2), -- A Game of Thrones - George R.R. Martin
(3, 3), -- Murder on the Orient Express - Agatha Christie
(4, 4), -- The Shining - Stephen King
(5, 5); -- The Hobbit - J.R.R. Tolkien

-- Insert sample Users
INSERT INTO Users (FirstName, LastName, Email, LibraryCardNumber, RegistrationDate, IsActive) VALUES
('John', 'Doe', 'john.doe@email.com', 'LIB001', '2023-01-15', TRUE),
('Jane', 'Smith', 'jane.smith@email.com', 'LIB002', '2023-02-20', TRUE),
('Mike', 'Johnson', 'mike.johnson@email.com', 'LIB003', '2023-03-10', TRUE);

-- Insert sample Rentals
INSERT INTO Rentals (BookID, UserID, RentalDate, DueDate, ReturnDate) VALUES
(1, 1, '2023-04-01', '2023-04-15', NULL),
(3, 2, '2023-04-05', '2023-04-19', '2023-04-18'),
(5, 3, '2023-04-10', '2023-04-24', NULL);

-- Insert sample Fine
INSERT INTO Fines (RentalID, Amount, IsPaid) VALUES
(2, 2.50, TRUE);

-- Update AvailableQuantity for rented books
UPDATE Books SET AvailableQuantity = Quantity - 1 WHERE BookID IN (1, 5);

-- Create a view for available books
CREATE VIEW vw_AvailableBooks AS
SELECT b.BookID, b.Title, b.ISBN, b.PublicationYear, g.GenreName, 
       GROUP_CONCAT(CONCAT(a.FirstName, ' ', a.LastName) SEPARATOR ', ') AS Authors,
       b.Description, b.AvailableQuantity
FROM Books b
JOIN Genres g ON b.GenreID = g.GenreID
JOIN BookAuthors ba ON b.BookID = ba.BookID
JOIN Authors a ON ba.AuthorID = a.AuthorID
WHERE b.AvailableQuantity > 0
GROUP BY b.BookID;

-- Create stored procedure for renting a book
DELIMITER //
CREATE PROCEDURE sp_RentBook(IN p_BookID INT, IN p_UserID INT, IN p_RentalDays INT)
BEGIN
    DECLARE v_AvailableQuantity INT;
    DECLARE v_DueDate DATE;
    DECLARE v_UserActive BOOLEAN;
    
    START TRANSACTION;
    
    -- Check if the user is active
    SELECT IsActive INTO v_UserActive
    FROM Users WHERE UserID = p_UserID;
    
    IF v_UserActive = FALSE THEN
        SELECT 'User account is inactive.' AS Result;
    ELSE
        -- Check if the book is available
        SELECT AvailableQuantity INTO v_AvailableQuantity
        FROM Books WHERE BookID = p_BookID FOR UPDATE;
        
        IF v_AvailableQuantity > 0 THEN
            -- Calculate due date
            SET v_DueDate = DATE_ADD(CURDATE(), INTERVAL p_RentalDays DAY);
            
            -- Insert new rental
            INSERT INTO Rentals (BookID, UserID, RentalDate, DueDate)
            VALUES (p_BookID, p_UserID, CURDATE(), v_DueDate);
            
            -- Update available quantity
            UPDATE Books
            SET AvailableQuantity = AvailableQuantity - 1
            WHERE BookID = p_BookID;
            
            SELECT 'Book rented successfully.' AS Result;
        ELSE
            SELECT 'Book is not available for rent.' AS Result;
        END IF;
    END IF;
    
    COMMIT;
END //
DELIMITER ;

-- Create stored procedure for returning a book
DELIMITER //
CREATE PROCEDURE sp_ReturnBook(IN p_RentalID INT)
BEGIN
    DECLARE v_BookID INT;
    DECLARE v_DueDate DATE;
    DECLARE v_DaysOverdue INT;
    DECLARE v_FineAmount DECIMAL(10, 2);
    
    START TRANSACTION;
    
    -- Get BookID and DueDate for the rental
    SELECT BookID, DueDate INTO v_BookID, v_DueDate
    FROM Rentals
    WHERE RentalID = p_RentalID AND ReturnDate IS NULL FOR UPDATE;
    
    IF v_BookID IS NOT NULL THEN
        -- Update rental with return date
        UPDATE Rentals
        SET ReturnDate = CURDATE()
        WHERE RentalID = p_RentalID;
        
        -- Update available quantity
        UPDATE Books
        SET AvailableQuantity = AvailableQuantity + 1
        WHERE BookID = v_BookID;
        
        -- Check if the book is overdue and create a fine if necessary
        SET v_DaysOverdue = DATEDIFF(CURDATE(), v_DueDate);
        IF v_DaysOverdue > 0 THEN
            SET v_FineAmount = v_DaysOverdue * 0.50; -- $0.50 per day
            
            INSERT INTO Fines (RentalID, Amount, IsPaid)
            VALUES (p_RentalID, v_FineAmount, FALSE);
            
            SELECT CONCAT('Book returned with a fine of $', v_FineAmount, ' for ', v_DaysOverdue, ' days overdue.') AS Result;
        ELSE
            SELECT 'Book returned successfully.' AS Result;
        END IF;
    ELSE
        SELECT 'Invalid rental or book already returned.' AS Result;
    END IF;
    
    COMMIT;
END //
DELIMITER ;

-- Create stored procedure for creating a new user
DELIMITER //
CREATE PROCEDURE sp_CreateUser(
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_Email VARCHAR(100),
    IN p_LibraryCardNumber VARCHAR(20)
)
BEGIN
    DECLARE v_EmailExists INT;
    DECLARE v_CardExists INT;
    
    -- Check if email already exists
    SELECT COUNT(*) INTO v_EmailExists FROM Users WHERE Email = p_Email;
    
    -- Check if library card number already exists
    SELECT COUNT(*) INTO v_CardExists FROM Users WHERE LibraryCardNumber = p_LibraryCardNumber;
    
    IF v_EmailExists > 0 THEN
        SELECT 'Email already exists.' AS Result;
    ELSEIF v_CardExists > 0 THEN
        SELECT 'Library card number already exists.' AS Result;
    ELSE
        INSERT INTO Users (FirstName, LastName, Email, LibraryCardNumber, RegistrationDate, IsActive)
        VALUES (p_FirstName, p_LastName, p_Email, p_LibraryCardNumber, CURDATE(), TRUE);
        
        SELECT 'User created successfully.' AS Result;
    END IF;
END //
DELIMITER ;

-- Create stored procedure for removing a library card
DELIMITER //
CREATE PROCEDURE sp_RemoveLibraryCard(IN p_UserID INT)
BEGIN
    DECLARE v_ActiveRentals INT;
    
    -- Check if user has active rentals
    SELECT COUNT(*) INTO v_ActiveRentals
    FROM Rentals
    WHERE UserID = p_UserID AND ReturnDate IS NULL;
    
    IF v_ActiveRentals > 0 THEN
        SELECT 'Cannot remove library card. User has active rentals.' AS Result;
    ELSE
        UPDATE Users
        SET IsActive = FALSE
        WHERE UserID = p_UserID;
        
        SELECT 'Library card removed successfully.' AS Result;
    END IF;
END //
DELIMITER ;

-- Create stored procedure for getting all users
DELIMITER //
CREATE PROCEDURE sp_GetAllUsers()
BEGIN
    SELECT 
        u.UserID,
        u.FirstName,
        u.LastName,
        u.Email,
        u.LibraryCardNumber,
        u.RegistrationDate,
        u.IsActive,
        COUNT(DISTINCT r.RentalID) AS BooksRented,
        COALESCE(SUM(f.Amount), 0) AS TotalFines
    FROM 
        Users u
    LEFT JOIN 
        Rentals r ON u.UserID = r.UserID
    LEFT JOIN 
        Fines f ON r.RentalID = f.RentalID
    GROUP BY 
        u.UserID;
END //
DELIMITER ;

-- Create stored procedure for searching users
DELIMITER //
CREATE PROCEDURE sp_SearchUsers(IN SearchTerm VARCHAR(100))
BEGIN
    SELECT 
        u.UserID,
        u.FirstName,
        u.LastName,
        u.Email,
        u.LibraryCardNumber,
        u.RegistrationDate,
        u.IsActive,
        COUNT(DISTINCT r.RentalID) AS BooksRented,
        COALESCE(SUM(f.Amount), 0) AS TotalFines
    FROM 
        Users u
    LEFT JOIN 
        Rentals r ON u.UserID = r.UserID
    LEFT JOIN 
        Fines f ON r.RentalID = f.RentalID
    WHERE 
        u.FirstName LIKE CONCAT('%', SearchTerm, '%') OR
        u.LastName LIKE CONCAT('%', SearchTerm, '%') OR
        u.Email LIKE CONCAT('%', SearchTerm, '%') OR
        u.LibraryCardNumber LIKE CONCAT('%', SearchTerm, '%')
    GROUP BY 
        u.UserID;
END //
DELIMITER ;

-- Create stored procedure for getting all rentals
DELIMITER //

CREATE PROCEDURE IF NOT EXISTS sp_GetAllRentals()
BEGIN
    SELECT 
        r.RentalID,
        b.Title AS BookTitle,
        CONCAT(u.FirstName, ' ', u.LastName) AS UserName,
        r.RentalDate,
        r.DueDate,
        r.ReturnDate,
        CASE 
            WHEN r.ReturnDate IS NULL AND CURDATE() > r.DueDate THEN 'Overdue'
            WHEN r.ReturnDate IS NULL THEN 'Active'
            ELSE 'Returned'
        END AS Status
    FROM 
        Rentals r
    JOIN 
        Books b ON r.BookID = b.BookID
    JOIN 
        Users u ON r.UserID = u.UserID
    ORDER BY 
        r.RentalDate DESC;
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE IF NOT EXISTS sp_AddNewBook(
    IN p_Title VARCHAR(255),
    IN p_ISBN VARCHAR(13),
    IN p_PublicationYear INT,
    IN p_Description TEXT,
    IN p_GenreID INT,
    IN p_Quantity INT,
    IN p_AuthorIDs VARCHAR(100) -- Comma-separated list of AuthorIDs
)
BEGIN
    DECLARE v_BookID INT;
    DECLARE v_AuthorID INT;
    DECLARE v_Done INT DEFAULT 0;
    DECLARE cur_Authors CURSOR FOR 
        SELECT TRIM(SUBSTRING_INDEX(SUBSTRING_INDEX(p_AuthorIDs, ',', numbers.n), ',', -1)) AS AuthorID
        FROM (SELECT 1 + units.i + tens.i * 10 AS n
              FROM (SELECT 0 AS i UNION SELECT 1 UNION SELECT 2 UNION SELECT 3 UNION SELECT 4 UNION SELECT 5 UNION SELECT 6 UNION SELECT 7 UNION SELECT 8 UNION SELECT 9) units,
                   (SELECT 0 AS i UNION SELECT 1 UNION SELECT 2 UNION SELECT 3 UNION SELECT 4 UNION SELECT 5 UNION SELECT 6 UNION SELECT 7 UNION SELECT 8 UNION SELECT 9) tens
             ) numbers
        WHERE numbers.n <= 1 + (LENGTH(p_AuthorIDs) - LENGTH(REPLACE(p_AuthorIDs, ',', '')));
    
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET v_Done = 1;
    
    -- Insert the new book
    INSERT INTO Books (Title, ISBN, PublicationYear, Description, GenreID, Quantity, AvailableQuantity)
    VALUES (p_Title, p_ISBN, p_PublicationYear, p_Description, p_GenreID, p_Quantity, p_Quantity);
    
    SET v_BookID = LAST_INSERT_ID();
    
    -- Link the book to its authors
    OPEN cur_Authors;
    
    author_loop: LOOP
        FETCH cur_Authors INTO v_AuthorID;
        IF v_Done THEN
            LEAVE author_loop;
        END IF;
        
        INSERT INTO BookAuthors (BookID, AuthorID) VALUES (v_BookID, v_AuthorID);
    END LOOP;
    
    CLOSE cur_Authors;
    
    SELECT 'Book added successfully.' AS Result;
END //

DELIMITER ;