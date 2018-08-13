using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblmember")]
    public class Member : Module
    {

        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;

        [Column(Name = "MemberID", DatabaseType = "varchar",IsUnique =true, Length = 24)DBForms.FormControl(isUnique =true,isMandetory =true,isNull =false)]
        public string MemberID { get; set; }

        [Column(Name = "FullName", DatabaseType = "varchar", Length = 40)]
        public string FullName { get; set; }

        [Column(Name = "BirthDate", DatabaseType = "date")]
        public DateTime BirthDate { get; set; } = DateTime.Now;

        [Column(Name = "JoiningDate", DatabaseType = "date")]
        public DateTime JoiningDate { get; set; } = DateTime.Now;

        [Column(Name = "Address", DatabaseType = "varchar", Length = 255)]
        public string Address { get; set; }

        [Column(Name = "Phone", DatabaseType = "varchar", Length = 20)]
        public string Phone { get; set; }

        [Column(Name = "Email", DatabaseType = "varchar", Length = 120)]
        public string Email { get; set; }

        [Column(Name = "Department", DatabaseType = "varchar", Length = 120)]
        public string Department { get; set; }

        [Column(Name = "IDCardNumber", DatabaseType = "varchar", Length = 20)]
        public string IDCardNumber { get; set; }

        [Column(Name = "MemberType", DatabaseType = "varchar", Length = 24)]
        public string MemberType { get; set; }

        [Column(Name = "Status", DatabaseType = "integer", Length = 3)]
        public STATUS Status { get; set; }

        [Column(Name = "Created", DatabaseType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP")]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
