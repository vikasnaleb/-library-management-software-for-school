using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.controllers
{
    internal class Book : MyController<tables.Book>
    {
        internal Book() : base()
        {
            
        }

        internal int TotalCoppies(CoppyStatus Status)
        {
            return BookCoppy.Count("BookID,Status", info.ID + "," + ((int)Status));
        }

        internal int TotalCoppies()
        {
            return BookCoppy.Count("BookID", info.ID.ToString());
        }
    }

    internal class BookCoppy : MyController<tables.BookCoppy>
    {
        internal BookCoppy() : base()
        {

        }
    }

    internal class BookCondition : MyController<tables.BookCondition>
    {
        internal BookCondition() : base()
        {

        }
    }

    internal class BookCategory : MyController<tables.BookCategory>
    {
        internal BookCategory() : base()
        {

        }
    }
}
