using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void btnRentBook_Click(object sender, EventArgs e)
        {
            RentBookForm rentBookForm = new RentBookForm();
            rentBookForm.ShowDialog();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.ShowDialog();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.ShowDialog();
        }

        private void btnRemoveLibraryCard_Click(object sender, EventArgs e)
        {
            RemoveLibraryCardForm removeLibraryCardForm = new RemoveLibraryCardForm();
            removeLibraryCardForm.ShowDialog();
        }

        private void btnViewAllBooks_Click(object sender, EventArgs e)
        {
            ViewAllBooksForm viewAllBooksForm = new ViewAllBooksForm();
            viewAllBooksForm.ShowDialog();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            ViewUsersForm viewUsersForm = new ViewUsersForm();
            viewUsersForm.ShowDialog();
        }

        private void btnViewRentals_Click(object sender, EventArgs e)
        {
            ViewRentalForm viewRentalForm = new ViewRentalForm();
            viewRentalForm.ShowDialog();
        }



    }
}