using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Eperator : User
    {
        DataAccess DAL;

        public Eperator()
        {
            DAL = new DataAccess();
        }

        public override string Login(string UserName, string Password)
        {
            string[] p = { "UserName", "Password", "UserID", "result" };
            string[] v = { UserName, Password, "", "" };
            ParameterDirection[] d = { ParameterDirection.InputOutput, ParameterDirection.Input, ParameterDirection.Output, ParameterDirection.Output };
            DAL.Connect();
            DAL.ExecuteProcedure("Login", p, ref v, d);
            DAL.Disconnect();
            string result = v[3];
            Eperator.UserName = v[0];
            Eperator.UserID = v[2];
            return result;
        }

        public DataTable ShowData()
        {
            DAL.Connect();
            DataTable dt = DAL.DoSelectProcedure("UserShowDate");
            DAL.Disconnect();
            return dt;
        }

        public bool Exists(string UserName)
        {
            string[] p = { "username" };
            string[] v = { UserName };
            DAL.Connect();
            bool result = (bool)DAL.ExecuteFunction("UserExists", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Insert(string Name, string Family, string Phone, string UserName, string Password, string Address, string Description)
        {
            string[] p = { "name", "family", "phone", "username", "password", "address", "description" };
            string[] v = { Name, Family, Phone, UserName, Password, Address, Description };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("UserInsert", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Edit(string UserID, string Name, string Family, string Phone, string UserName, string Password, string Address, string Description)
        {
            string[] p = { "UserID", "name", "family", "phone", "username", "password", "address", "description" };
            string[] v = { UserID, Name, Family, Phone, UserName, Password, Address, Description };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("UserEdit", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Delete(string UserID)
        {
            string[] p = { "UserID" };
            string[] v = { UserID };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("UserDelete", p, v);
            DAL.Disconnect();
            return result;
        }

        public int SetAccessLevel(string UserID, int Student, int Term, int Room, int Payment, int NewRegistration, int OldRegistration, int PaymentList, int DeptorList, int AddressBook, int Calculator)
        {
            string[] p = { "UserID", "student", "term", "room", "payment", "newregistration", "oldregistration", "paymentlist", "deptorlist", "addressbook", "calculator" };
            object[] v = { UserID, Student, Term, Room, Payment, NewRegistration, OldRegistration, PaymentList, DeptorList, AddressBook, Calculator };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("SetAccessLevel", p, v);
            DAL.Disconnect();
            return result;
        }

        public void GetAccessLevel(string UserID)
        {
            string[] p = { "UserID", "student", "term", "room", "payment", "newregistration", "oldregistration", "paymentlist", "deptorlist", "addressbook", "calculator" };
            string[] v = { UserID, "", "", "", "", "", "", "", "", "", "" }; 
            ParameterDirection[] d = { ParameterDirection.Input, ParameterDirection.Output, ParameterDirection.Output, ParameterDirection.Output, ParameterDirection.Output, ParameterDirection.Output, ParameterDirection.Output, ParameterDirection.Output, ParameterDirection.Output, ParameterDirection.Output, ParameterDirection.Output };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("GetAccessLevel", p, ref v, d);
            DAL.Disconnect();
            if (v[1] == "1") AccessLevel.Student = true; else AccessLevel.Student = false;
            if (v[2] == "1") AccessLevel.Term = true; else AccessLevel.Term = false;
            if (v[3] == "1") AccessLevel.Room = true; else AccessLevel.Room = false;
            if (v[4] == "1") AccessLevel.Payment = true; else AccessLevel.Payment = false;
            if (v[5] == "1") AccessLevel.NewRegistration = true; else AccessLevel.NewRegistration = false;
            if (v[6] == "1") AccessLevel.OldRegistration = true; else AccessLevel.OldRegistration = false;
            if (v[7] == "1") AccessLevel.PaymentList = true; else AccessLevel.PaymentList = false;
            if (v[8] == "1") AccessLevel.DebtorsList = true; else AccessLevel.DebtorsList = false;
            if (v[9] == "1") AccessLevel.AddressBook = true; else AccessLevel.AddressBook = false;
            if (v[10]== "1") AccessLevel.Calculator = true; else AccessLevel.Calculator = false;
        }
    }
}
