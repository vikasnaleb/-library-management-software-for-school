using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.controllers;

namespace LibraryManagment
{
    internal static class Core
    {
        internal static App application { get; private set; }
        internal static User _user { get; set; }

        internal static void Initialize()
        {
            application = new App();
            _user = new User();
        }

        internal static void Logout()
        {
            _user = new User();
            System.Windows.Forms.Application.Restart();
        }

        internal static void InitializeDatabase()
        {
            try
            {
                new Application();
                new Settings();
                new User();
                new Member();
                new Book();
                new BookCoppy();
                new BookCategory();
                new Member();
                new MyController<tables.MemberType>();
                new BookCondition();
                new UserLogs();
                new SoftwareLogs();
                new Circulation();
            }
            catch (AccessViolationException)
            {
                throw new Exception("File permition error occured. restart software with admin previliges. (Right click on software -> Run as admin)");
            }
        }

        internal static void InitializeSoftware()
        {

        }

        internal static void Userlog(string details)
        {
            new Logger().log(details, Logger.LogType.USER);
        }

        internal static void Systemlog(string details)
        {
            if (_user != null)
                new Logger().log(details, Logger.LogType.SYSTEM);
            else
                new Logger().log(details, Logger.LogType.SYSTEM);
        }
    }
}
