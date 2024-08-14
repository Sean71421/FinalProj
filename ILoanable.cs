using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    /// <summary>
    /// Explaisn for the methods for items that can be loaned out from the library.
    /// </summary>
    public interface ILoanable
    {
        void Checkout(int userID);
        void Return();
    }
}