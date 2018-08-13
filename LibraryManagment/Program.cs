using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Core.Initialize();
            Core.InitializeDatabase();
            Core.Systemlog("System Started...");
            Application.ApplicationExit += delegate (object s, EventArgs e)
            {
                if (Core._user != null)
                    Core.Systemlog("System Exit...");
                else
                    Core.Systemlog("System Exit...");
            };
            forms.Login fLogin = new forms.Login();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                forms.Main obj = new forms.Main();
                Application.Run(obj);
            }
            else
            {
                Application.Exit();

            }
            //}
            //catch(Exception e)
            //{
            //    MessageBox.Show("Exception occured in application",e.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }
    }
}
