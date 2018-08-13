using db;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblBookCategory")]
    public class BookCategory : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;

        [Column(Name = "CategoryName", DatabaseType = "varchar", Length = 63)]
        public string CategoryName { get; set; }

        [Column(Name = "Created", DatabaseType = "TIMESTAMP", DefaultValue = "CURRENT_TIMESTAMP")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Association(OtherKey = nameof(Book.CategoryID))]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
