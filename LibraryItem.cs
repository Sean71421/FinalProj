using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    /// <summary>
    /// Represents a item in The library System.
    /// </summary>
    public abstract class LibraryItem
    {
        public int ID { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// info About The Library Item.
        /// </summary>
        public abstract void Display();
    }
}
