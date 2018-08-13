using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblCirculation")]
    public class Circulation : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;


        [Column(Name = "MemberID", DatabaseType = "varchar", Length = 24)]
        public string MemberID { get; set; }

        [Column(Name = "BookID", DatabaseType = "integer", Length = 11)]
        public long BookID { get; set; }


        [Column(Name = "CoppyNo", DatabaseType = "varchar", Length = 20)]
        public string CoppyNo { get; set; }


        [Column(Name = "BookTitle", DatabaseType = "varchar", Length = 120)]
        public string BookTitle { get; set; }

        [Column(Name = "RegisterNo", DatabaseType = "varchar", Length = 30)]
        public string RegisterNo { get; set; }


        [Column(Name = "Fine", DatabaseType = "double", Length = 10, Length2 = 2)]
        public double Fine { get; set; }

        [Column(Name = "IssuedDate", DatabaseType = "date")]
        public DateTime IssuedDate { get; set; } = DateTime.Now;

        [Column(Name = "ReturnDate", DatabaseType = "date")]
        public DateTime ReturnDate { get; set; } = DateTime.Now.AddDays(8);

        [Column(Name = "FineStatus", DatabaseType = "varchar", Length = 30)]
        public FineStatus FineStatus { get; set; }

        [Column(Name = "Status", DatabaseType = "varchar", Length = 30)]
        public CirculationStatus Status { get; set; }


        [Column(Name = "Note", DatabaseType = "varchar", Length = 240)]
        public string Note { get; set; } = "";

    }
}
