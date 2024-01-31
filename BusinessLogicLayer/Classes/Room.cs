using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Room
    {
        DataAccess DAL;

        public Room()
        {
            DAL = new DataAccess();
        }

        public bool Exists(string Number)
        {
            string[] p = { "number" };
            string[] v = { Number };
            DAL.Connect();
            bool result = (bool)DAL.ExecuteFunction("RoomExists", p, v);
            DAL.Disconnect();
            return result;
        }

        public DataTable ShowData(string value)
        {
            SqlParameter[] p = { new SqlParameter("type", value) };
            DAL.Connect();
            DataTable dt = DAL.DoSelectProcedure("RoomShowDate", p);
            DAL.Disconnect();
            return dt;
        }

        public DataTable DeviceShowData(string value)
        {
            SqlParameter[] p = { new SqlParameter("RoomID", value) };
            DAL.Connect();
            DataTable dt = DAL.DoSelectProcedure("DeviceShowDate", p);
            DAL.Disconnect();
            return dt;
        }

        public int Insert(string Number, string Capicity)
        {
            string[] p = { "number", "capicity" };
            string[] v = { Number, Capicity };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("RoomInsert", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Edit(string RoomID, string Number, string Capicity)
        {
            string[] p = { "RoomID", "number", "capicity" };
            string[] v = { RoomID, Number, Capicity };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("RoomEdit", p, v);
            DAL.Disconnect();
            return result;
        }

        public int AddDevice(string RoomID, string Name, string Quantity)
        {
            string[] p = { "RoomID", "name", "quantity" };
            string[] v = { RoomID, Name, Quantity };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("DeviceInsert", p, v);
            DAL.Disconnect();
            return result;
        }

        public int EditDevice(string DeviceID, string Name, string Quantity)
        {
            string[] p = { "DeviceID", "name", "quantity" };
            string[] v = { DeviceID, Name, Quantity };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("DeviceEdit", p, v);
            DAL.Disconnect();
            return result;
        }

        public int RemoveDevice(string DeviceID)
        {
            string[] p = { "DeviceID"};
            string[] v = { DeviceID};
            DAL.Connect();
            int result = DAL.ExecuteProcedure("DeviceDeiete", p, v);
            DAL.Disconnect();
            return result;
        }

        public string GetRemainderRoom(string RoomID)
        {
            string[] p = { "RoomID", "result" };
            string[] v = { RoomID, "" };
            ParameterDirection[] d = { ParameterDirection.Input, ParameterDirection.Output };
            DAL.Connect();
            DAL.ExecuteProcedure("GetRemainderRoom", p, ref  v, d);
            DAL.Disconnect();
            return v[1];
        }
    }
}
