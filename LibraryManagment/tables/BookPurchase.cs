using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblBookPurchase")]
    public class BookPurchase : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;
                   
        [Column(Name = "Title", DatabaseType = "varchar", Length = 120)]
        public string Title { get; set; }

        [Column(Name = "ApprovedBy", DatabaseType = "varchar", Length = 120)]
        public string ApprovedBy { get; set; }
        
        [Column(Name = "Publisher", DatabaseType = "varchar", Length = 120)]
        public string Publisher { get; set; }

        [Column(Name = "Author", DatabaseType = "varchar", Length = 120)]
        public string Author { get; set; }

        [Column(Name = "Quantity", DatabaseType = "integer", Length = 8)]
        public double Quantity { get; set; }

        [Column(Name = "Price", DatabaseType = "double", Length = 10,Length2 =2)]
        public double Price { get; set; }

        [Column(Name = "PurchaseDate", DatabaseType = "date", DefaultValue = "date")]
        public DateTime PurchaseDate { get; set; }

        [Column(Name = "UpdateBy", DatabaseType = "varchar", Length = 120)]
        public string UpdateBy { get; set; }

        [Column(Name = "Updated", DatabaseType = "date", DefaultValue = "date")]
        public DateTime Updated { get; set; }

        [Column(Name = "Created", DatabaseType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP")]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
