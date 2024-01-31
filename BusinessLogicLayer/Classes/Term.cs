using System.Data;
using DataAccessLayer;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class Term
    {
        DataAccess DAL;

        public Term()
        {
        
            DAL = new DataAccess();
        }

        public bool Exists(string Name)
        {
            string[] p = { "name" };
            string[] v = { Name };
            DAL.Connect();
            bool result = (bool)DAL.ExecuteFunction("TermExists", p, v);
            DAL.Disconnect();
            return result;
        }

        public DataTable ShowData(string value)
        {
            SqlParameter[] p = { new SqlParameter("type", value) };
            DAL.Connect();
            DataTable dt = DAL.DoSelectProcedure("TermShowData", p);
            DAL.Disconnect();
            return dt;
        }

        public DataTable GetCensus(string TermID)
        {
            SqlParameter[] p = { new SqlParameter("TermID", TermID) };
            DAL.Connect();
            DataTable dt = DAL.DoSelectProcedure("GetCensus", p);
            DAL.Disconnect();
            return dt;
        }

        public int Insert(string Name, string StartDate, string EndDate, string TotalPrice)
        {
            string[] p = { "name", "startdate", "enddate", "totalprice" };
            string[] v = { Name, StartDate, EndDate, TotalPrice };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("TermInsert", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Edit(string TermID, string Name, string StartDate, string EndDate, string TotalPrice)
        {
            string[] p = { "TermID", "name", "startdate", "enddate", "totalprice" };
            string[] v = { TermID, Name, StartDate, EndDate, TotalPrice };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("TermEdit", p, v);
            DAL.Disconnect();
            return result;
        }

        public float GetTotalPrice(string TermID)
        {
            string[] p = { "TermID", "Price" };
            string[] v = { TermID, "" };
            ParameterDirection[] d = { ParameterDirection.Input, ParameterDirection.Output };
            DAL.Connect();
            DAL.ExecuteProcedure("GetTotalPrice", p, ref  v, d);
            DAL.Disconnect();
            return float.Parse(v[1]);
        }
    }
}
