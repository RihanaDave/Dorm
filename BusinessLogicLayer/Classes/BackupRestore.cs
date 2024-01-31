using System;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BackupRestore
    {
        DataAccess DAL;

        public BackupRestore()
        {
            DAL = new DataAccess();
        }

        public string  Backup(string path)
        {
            string[] p = { "path", "result" };
            string[] v = { path, "" };
            ParameterDirection[] d = { ParameterDirection.Input, ParameterDirection.Output };
            DAL.Connect();
            DAL.ExecuteProcedure("BackupDatabase", p, ref  v, d);
            DAL.Disconnect();
            return v[1];
        }

        public string  Restore(string path)
        {
            string[] p = { "path", "result" };
            string[] v = { path, "" };
            ParameterDirection[] d = { ParameterDirection.Input, ParameterDirection.Output };
            DAL.Connect();
            DAL.ExecuteProcedure("RestoreDatabase", p, ref  v, d);
            DAL.Disconnect();
            return v[1];
        }
    }
}
