using db;
using DBForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tbluser")]
    public class User : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;

        [Column(Name = "SID", DatabaseType = "integer", Length = 11)]
        public long SID { get; set; }

        [Column(Name = "UFName", DatabaseType = "varchar", Length = 40)]
        public string FirstName { get; set; }

        [Column(Name = "UMName", DatabaseType = "varchar", Length = 40)]
        public string MiddleName { get; set; }

        [Column(Name = "ULName", DatabaseType = "varchar", Length = 40)]
        public string LastName { get; set; }

        [Column(Name = "UAddress", DatabaseType = "varchar", Length = 255)]
        public string Address { get; set; }

        [Column(Name = "UContactNo", DatabaseType = "varchar", Length = 20)]
        public string Phone { get; set; }

        [Column(Name = "UEmailID", DatabaseType = "varchar", Length = 120)]
        public string Email { get; set; }

        [Column(Name = "UserType", DatabaseType = "integer", Length = 3)]
        public UserTypes UserType { get; set; }

        [Column(Name = "UserID", DatabaseType = "varchar", Length = 24)FormControl(isUnique = true)]
        public string Username { get; set; }

        [Column(Name = "Password", DatabaseType = "varchar", Length = 24)]
        public string Password { get; set; }

        [Column(Name = "Active", DatabaseType = "integer", Length = 3)]
        public STATUS Active { get; set; } 
    }
}
