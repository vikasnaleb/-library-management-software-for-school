using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblbook")]
    public class Book : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1; 

        [Column(Name = "ISBN", DatabaseType = "varchar", Length = 24)]
        public string ISBN { get; set; }

        [Column(Name = "RegisterNo", DatabaseType = "varchar", Length = 30)]
        public string RegisterNo { get; set; }

        [Column(Name = "Title", DatabaseType = "varchar", Length = 120)]
        public string Title { get; set; }

        [Column(Name = "Publisher", DatabaseType = "varchar", Length = 120)]
        public string Publisher { get; set; }

        [Column(Name = "Author", DatabaseType = "varchar", Length = 120)]
        public string Author { get; set; }

        [Column(Name = "Edition", DatabaseType = "varchar", Length = 120)]
        public string Edition { get; set; }

        [Column(Name = "PublishingYear", DatabaseType = "varchar", Length = 120)]
        public string PublishingYear { get; set; }

        [Column(Name = "CategoryID", DatabaseType = "integer", Length = 4)]
        public int  CategoryID { get; set; }

        [Column(Name = "Price", DatabaseType = "double", Length = 10, Length2 = 2)]
        public double Price { get; set; }

        [Column(Name = "Created", DatabaseType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Association(ThisKey = nameof(CategoryID))]
        public BookCategory Category { get; set; }
    }
}
