using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables.view
{
    [Table(Name = "tblBookCoppy")]
    public class BookCoppy : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1; 

        [Column(Name = "CoppyNo", DatabaseType = "varchar", Length = 20)DBForms.FormControl(isUnique = true, isMandetory = true)]
        public string CoppyNo { get; set; }

        [Column(Name = "Title", DatabaseType = "varchar", Length = 120)]
        public string Title { get; set; }

        [Column(Name = "Author", DatabaseType = "varchar", Length = 120)]
        public string Author { get; set; }

        [Column(Name = "Edition", DatabaseType = "varchar", Length = 120)]
        public string Edition { get; set; }
         
        [Column(Name = "Price", DatabaseType = "double", Length = 10, Length2 = 2)]
        public double Price { get; set; }

        [Column(Name = "Status", DatabaseType = "integer", Length = 2)]
        public CoppyStatus Status { get; set; }
    }
}
