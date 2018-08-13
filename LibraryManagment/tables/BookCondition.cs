using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblBookCondition")]
    public class BookCondition : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;

        [Column(Name = "CoppyNo", DatabaseType = "varchar", Length = 20)]
        public string CoppyNo { get; set; }

        [Column(Name = "Description", DatabaseType = "varchar", Length = 220)]
        public string Description { get; set; }

        [Column(Name = "ReportedDate", DatabaseType = "date")]
        public DateTime ReportedDate { get; set; }

        [Column(Name = "Status", DatabaseType = "integer", Length = 2)]
        public CoppyCondition Status { get; set; }

        [Column(Name = "Created", DatabaseType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Association(OtherKey = nameof(Book.CategoryID))]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
