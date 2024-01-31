using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Student
    {
        DataAccess DAL;

        public Student()
        {
            DAL = new DataAccess();
        }

        public bool Exists(string Name, string Family, string FatherName)
        {
            string[] p = { "name", "family", "fathername" };
            string[] v = { Name, Family, FatherName };
            DAL.Connect();
            bool result = (bool)DAL.ExecuteFunction("StudentExists", p, v);
            DAL.Disconnect();
            return result;
        }

        public DataTable ShowData()
        {
            DAL.Connect();
            DataTable dt = DAL.DoSelectProcedure("StudentShowData");
            DAL.Disconnect();
            return dt;
        }

        public DataTable ShowPaymentList(string StudentID, string TermID)
        {
            SqlParameter[] p = { new SqlParameter("StudentID", StudentID), new SqlParameter("TermID", TermID) };
            DAL.Connect();
            DataTable result = DAL.DoSelectProcedure("PaymentList", p);
            DAL.Disconnect();
            return result;
        }

        public DataTable ShowStudentInTerm(string TermID)
        {
            SqlParameter[] p = { new SqlParameter("TermID", TermID) };
            DAL.Connect();
            DataTable dt = DAL.DoSelectProcedure("StudentInTerm", p);
            DAL.Disconnect();
            return dt;
        }

        public DataTable DebtorsList(string TermID)
        {
            SqlParameter[] p = { new SqlParameter("TermID", TermID) };
            DAL.Connect();
            DataTable result = DAL.DoSelectProcedure("DebtorsList", p);
            DAL.Disconnect();
            return result;
        }

        public int Insert(string RoomID,string Name, string Family, string FatherName, string CellPhone, string HomePhone, string FatherTell, string Feild, string Entry, string Address, string Description)
        {
            string[] p = { "RoomID", "name", "family", "fathername", "cellphone", "homephone", "fathertel", "feild", "entery", "address", "description" };
            string[] v = { RoomID, Name, Family, FatherName, CellPhone, HomePhone, FatherTell, Feild, Entry, Address, Description };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("StudentInsert", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Edit(string StudentID, string Name, string Family, string FatherName, string CellPhone, string HomePhone, string FatherTell, string Feild, string Entry, string Address, string Description)
        {
            string[] p = { "StudentID",  "name", "family", "fathername", "cellphone", "homephone", "fathertel", "feild", "entery", "address", "description" };
            string[] v = { StudentID , Name, Family, FatherName, CellPhone, HomePhone, FatherTell, Feild, Entry, Address, Description };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("StudentEdit", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Delete(string StudentID)
        {
            string[] p = { "StudentID" };
            string[] v = { StudentID };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("StudentDelete", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Pay(string StudentID, string TermID, string PayTypeID, string UserID, string Price, string Date, string CheckDate, string CheckNumber)
        {
            string[] p = { "StudentID", "TermID", "PayTypeID", "UserID", "price", "date", "checkdate", "checknumber" };
            string[] v = { StudentID, TermID, PayTypeID, UserID, Price, Date, CheckDate, CheckNumber };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("Pay", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Registration(string StudentID, string TermID)
        {
            string[] p = { "StudentID", "TermID" };
            string[] v = { StudentID, TermID };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("Registration", p, v);
            DAL.Disconnect();
            return result;
        }

        public string GetLastIdentity()
        {
            string[] p = { "last" };
            string[] v = { "" };
            ParameterDirection[] d = { ParameterDirection.Output };
            DAL.Connect();
            DAL.ExecuteProcedure("GetLastIdentityStudent", p, ref  v, d);
            DAL.Disconnect();
            return v[0];
        }

        public int ChangeRoom(string StudentID,string RoomID)
        {
            string[] p = { "StudentID", "RoomID" };
            string[] v = { StudentID ,RoomID  };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("ChangeRoom", p, v);
            DAL.Disconnect();
            return result;
        }
    }
}
