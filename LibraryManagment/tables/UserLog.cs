using db;
using DBForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.tables
{
    [Table(Name = "tblUserLog")]
    public class UserLog : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;

        [Column(Name = "UserName", DatabaseType = "varchar", Length = 24)FormControl(isUnique = true)]
        public string UserName { get; set; }

        [Column(Name = "FirstName", DatabaseType = "varchar", Length = 40)]
        public string FirstName { get; set; }

        [Column(Name = "LastName", DatabaseType = "varchar", Length = 40)]
        public string LastName { get; set; }

        [Column(Name = "Details", DatabaseType = "varchar", Length = 250)]
        public string Details { get; set; }

        [Column(Name = "Created", DatabaseType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP")]
        public DateTime Created { get; set; } = DateTime.Now;
    }

    [Table(Name = "tblSoftwareLog")]
    public class SoftwareLogs : Module
    {
        [Column(Name = "ID", DatabaseType = "integer", Length = 11, IsAutoIncriment = true, IsPrimaryKey = true)]
        public override long ID { get; set; } = -1;

        [Column(Name = "UserName", DatabaseType = "varchar", Length = 24)FormControl(isUnique = true)]
        public string UserName { get; set; }

        [Column(Name = "FirstName", DatabaseType = "varchar", Length = 40)]
        public string FirstName { get; set; }

        [Column(Name = "LastName", DatabaseType = "varchar", Length = 40)]
        public string LastName { get; set; }

        [Column(Name = "Details", DatabaseType = "varchar", Length = 250)]
        public string Details { get; set; }

        [Column(Name = "Created", DatabaseType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP")]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
