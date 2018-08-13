using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.controllers
{
    internal class User : MyController<tables.User>
    {
        internal User() :base()
        {
            if (Count() <= 0)
            {
                info = new tables.User();
                info.Username = "Demo";
                info.Password = db.Helper.Cripto.IncriptTextNormal("1234", App.PRODUCT);
                info.FirstName = "Demo";
                info.Active = STATUS.ACTIVE;
                info.UserType = UserTypes.Admin;
                Save();
            }
        }

        internal static bool Check(string Username, string Password)
        {
            bool flag = false;
            User temp = new User();
            Password = db.Helper.Cripto.IncriptTextNormal(Password, App.PRODUCT);
            temp.First("Username,Password", Username, Password);
            if (temp.info != null && temp.info.ID >= 0)// && info.Active == STATUS.ACTIVE)
            {
                flag = true;
            }
            return flag;
        }

        internal bool Set(string Username, string Password)
        {
            bool flag = false;
            Password = db.Helper.Cripto.IncriptTextNormal(Password, App.PRODUCT);
            First("Username,Password", Username, Password);
            if (info != null && info.ID >= 0 && info.Active == STATUS.ACTIVE)
            {
                flag = true;
            }
            return flag;
        }

        internal bool changePassword(string oldpassword,string newpassword)
        {
            if (this.info != null && info.ID > 0)
            {
                this.Set(this.info.ID);
                return (this.info.Password == db.Helper.Cripto.IncriptTextNormal(oldpassword, App.PRODUCT));
            }
            return false;
        } 
    }
}
