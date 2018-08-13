using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.controllers
{
    internal class SoftwareLogs : MyController<tables.SoftwareLogs>
    {
        internal SoftwareLogs() : base()
        {

        }
        internal void log(string details, long user_id )
        {
            info.UserName = "BeforLogin";
            info.FirstName = "";
            info.LastName = "";
            if (user_id > 0)
            {
                User user = new User();
                user.Set(user_id);
                info.UserName = user.info.Username;
                info.FirstName = user.info.FirstName;
                info.LastName = user.info.LastName;
            }
            info.Details = details;
            Save();
        }
        internal void log(string details)
        {
            info.UserName = "BeforLogin";
            info.FirstName = "";
            info.LastName = "";
            info.Details = details;
            Save();
        }
    }

    internal class UserLogs : MyController<tables.UserLog>
    {
        internal UserLogs() : base()
        {

        }
        internal void log(string details, long user_id)
        {
            User user = new User();
            user.Set(user_id);
            info.Details = details;
            info.UserName = user.info.Username;
            info.FirstName = user.info.FirstName;
            info.LastName = user.info.LastName;
            Save();
        }
    }

    internal class Logger
    {
        internal enum LogType {  USER, SYSTEM };
        SoftwareLogs slogger;
        UserLogs ulogger;

        internal Logger()
        {
             slogger = new SoftwareLogs();
             ulogger = new UserLogs();
        }

        internal void log(string details, LogType type)
        {
            if (type == LogType.USER)
            {
                if (Core._user != null)
                    ulogger.log(details, Core._user.info.ID);
                else
                    ulogger.log(details, 0);
            }
            else
            {
                if (Core._user != null)
                    slogger.log(details, Core._user.info.ID);
                else
                    slogger.log(details);
            }
        }      
    }
}
