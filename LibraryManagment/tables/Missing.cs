using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblbook")]
    public class MissingBook : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;

        [Column(Name = "BookID", DatabaseType = "integer", Length = 11)]
        public int BookID { get; set; }

        [Column(Name = "CoppyNo", DatabaseType = "varchar", Length = 20)]
        public string CoppyNo { get; set; }


        [Column(Name = "Title", DatabaseType = "varchar", Length = 120)]
        public string Title { get; set; }

        [Column(Name = "Author", DatabaseType = "varchar", Length = 120)]
        public string Author { get; set; }

        [Column(Name = "Edition", DatabaseType = "varchar", Length = 120)]
        public string Edition { get; set; }

        [Column(Name = "MissingDate", DatabaseType = "date")]
        public DateTime MissingDate { get; set; } = DateTime.Now;

        [Column(Name = "Price", DatabaseType = "double", Length = 10, Length2 = 2)]
        public double Price { get; set; }

        [Column(Name = "Note", DatabaseType = "varchar", Length = 120)]
        public string Note { get; set; }


        [Column(Name = "Created", DatabaseType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Association(ThisKey = nameof(BookID))]
        public Book Book { get; set; }
    }
}
