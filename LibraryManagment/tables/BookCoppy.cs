using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblBookCoppy")]
    public class BookCoppy : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1; 

        [Column(Name = "BookID", DatabaseType = "integer", Length = 11,IsUnique =true)]
        public long  BookID { get; set; }

        [Column(Name = "CoppyNo", DatabaseType = "varchar", Length = 20)DBForms.FormControl(isUnique = true, isMandetory = true)]
        public string CoppyNo { get; set; }


        [Column(Name = "Title", DatabaseType = "varchar", Length = 120)]
        public string Title { get; set; }

        [Column(Name = "Author", DatabaseType = "varchar", Length = 120)]
        public string Author { get; set; }

        [Column(Name = "Edition", DatabaseType = "varchar", Length = 120)]
        public string Edition { get; set; }

         
        [Column(Name = "Vender", DatabaseType = "varchar", Length = 120)]
        public string Vender { get; set; }

        [Column(Name = "BillNo", DatabaseType = "varchar", Length = 42)]
        public string BillNo { get; set; }

        [Column(Name = "RecivedFrom", DatabaseType = "varchar", Length = 120)]
        public string RecivedFrom { get; set; }

        [Column(Name = "PurchaseDate", DatabaseType = "date")]
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        [Column(Name = "Price", DatabaseType = "double", Length = 10, Length2 = 2)]
        public double Price { get; set; }

        [Column(Name = "Note", DatabaseType = "varchar", Length = 120)]
        public string Note { get; set; }

        [Column(Name = "Status", DatabaseType = "integer", Length = 2)]
        public CoppyStatus Status { get; set; }


        [Column(Name = "Created", DatabaseType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Association(ThisKey = nameof(BookID))]
        public Book Book { get; set; }
    }
}
