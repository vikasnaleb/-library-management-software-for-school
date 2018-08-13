using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblSettings")]
    public class Settings : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;

        [Column(Name = "InstituteName", DatabaseType = "varchar", Length = 120)]
        public string InstituteName { get; set; }

        [Column(Name = "InstituteAddress", DatabaseType = "varchar", Length = 120)]
        public string InstituteAddress { get; set; }

        [Column(Name = "InstituteEmail", DatabaseType = "varchar", Length = 120)]
        public string InstituteEmail { get; set; }

        [Column(Name = "InstituteContact", DatabaseType = "varchar", Length = 120)]
        public string InstituteContact { get; set; }

        [Column(Name = "InstituteState", DatabaseType = "varchar", Length = 120)]
        public string InstituteState { get; set; }

        [Column(Name = "InstituteDistrict", DatabaseType = "varchar", Length = 120)]
        public string InstituteDistrict { get; set; }

        [Column(Name = "InstitutePinCode", DatabaseType = "varchar", Length = 120)]
        public string InstitutePinCode { get; set; }

        [Column(Name = "InstituteLogo", DatabaseType = "BLOB")]
        public byte[] InstituteLogo { get; set; }

        [Column(Name = "InstituteBackground", DatabaseType = "LONGBLOB" )]
        public byte[] InstituteBackground { get; set; }

        [Column(Name = "TimeZone", DatabaseType = "int", Length = 4)]
        public TIMEZONE TimeZone { get; set; }

        [Column(Name = "Currency", DatabaseType = "varchar", Length = 8)]
        public string Currency { get; set; }
          
    }
}
