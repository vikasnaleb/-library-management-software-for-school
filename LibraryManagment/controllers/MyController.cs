using db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.controllers
{
    internal class MyController<T> : Controller<T> where T : Module, new()
    {
        internal MyController() : base(Core.application.getDatabaseConnection())
        {
            VerifyDatabase();           
        }
    }
}