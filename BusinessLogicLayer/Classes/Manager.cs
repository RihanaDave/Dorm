using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Manager : User
    {
        DataAccess DAL;

        public Manager()
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
            Manager.UserName = "مدیر سیستم";
            Manager.UserID = v[2];
            return result;
        }

        public int ChangePassword(string NewPassword)
        {
            string[] p = { "Password" };
            string[] v = { NewPassword };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("ChangeManagerPassword", p, v);
            DAL.Disconnect();
            return result;
        }

        public string GetPassword()
        {
            string[] p = { "password" };
            string[] v = { "" };
            ParameterDirection[] d = { ParameterDirection.Output };
            DAL.Connect();
            DAL.ExecuteProcedure("GetManagerPassword", p, ref  v, d);
            DAL.Disconnect();
            return v[0];
        }
    }
}
