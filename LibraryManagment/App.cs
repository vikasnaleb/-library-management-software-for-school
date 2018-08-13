using LibraryManagment.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment
{
    public enum Prifix { Mr, Mrs, Miss, Dr };
    public enum Gender { Male, Female, Other };
    public enum PatientType { Old, New };
    public enum PaymentStatus { DUE, PAID };
    public enum ExpenceTypes { Advertising, Insurance, Vehical, Travel, Commissions, Tax, Labor, Wages, Services, Rent, Maintenance, Utilities, Supplies, Salaries, Depreciation, BadBebts, Fuel, Licence, Telephone, Warranties, Micellaneous };
    public enum PaymentModes { CASH, BANKACCOUNT, CARDPAY, CHEQU, PAYTM, TEJ, OTHER };
    public enum BillStatus { CANCELED, DONE };
    public enum UserTypes { Admin, Employee }
    public enum STATUS { INACTIVE, ACTIVE }
    public enum LOANSTATUS { DUE, ACTIVE, CANCELED, PAID }
    public enum DatabaseTypes { SqLite, MySql, SQLServer, Access }
    public enum LogType { LOGIN, SETTINGS, USER, ACCOUNT, LAB, TREATMENT, REPORT }
    public enum Months { NA, Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sap, Oct, Nov, Dec }
    public enum TIMEZONE { GMT, ECT, EET, ART, EAT, MET,NET,PLT,IST,BST,VST,CTT,JST,ACT,AET,SST,NST,MIT,HST,AST,PST,PNT,MST,CST,EST,IET,PRT,CNT,AGT,BET,CAT }
    public enum CoppyStatus { Avelable, Issued, Missing, Bad, Destroid }
    public enum CoppyCondition { Avelable, Missing, Bad, Destroid }
    public enum CirculationStatus { Returned, Issued, Missing }
    public enum FineStatus { PAID, UNPAID, NA}

    internal class App
    {
        internal const int PRODUCT = 2;
        internal static System.Drawing.Image MainBackground;

        string host = "localhost";
        //int port = 3306;
        string database = "test";
        string username = "root";
        string password = "";
        internal System.Data.IDbConnection getDatabaseConnection()
        {
            return db.Helper.Mysql_lib.Connection(host, database, username, password);
        }

        internal System.Data.IDbConnection getServerConnection()
        {
            return db.Helper.Mysql_lib.Connection(host, database, username, password);
        }
        internal void BackupDatabase()
        {
            db.Helper.Mysql_lib.Export(host, database, username, password);
        }

        internal void RestoreDatabase()
        {
            db.Helper.Mysql_lib.Import(host, database, username, password);
        }

        internal void BackupFiles()
        {
            
        }

        internal void RestoreFiles()
        {
            
        }

        internal void testDatabase()
        {

        }
         
    }

}