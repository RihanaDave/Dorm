using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccess
    {
        SqlDataAdapter Da;
        SqlConnection objConnection;
        SqlCommand objCommand;
        
        public DataAccess()
        {
            Da = new SqlDataAdapter();
            objConnection = new SqlConnection();
            objCommand = new SqlCommand();
            objCommand.Connection = objConnection;
        }

        public bool Connect()
        {
            if (objConnection.State != ConnectionState.Open)
            {
                try
                {
                    objConnection.ConnectionString = ConnectionString.GetConnectionString();
                    objConnection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                if (objConnection.State == ConnectionState.Open)
                    return true;
                else
                    return false;
            }
        }

        public DataTable DoSelect(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = query;
                if (dt != null)
                    dt.Clear();
                Da.SelectCommand = objCommand;
                Da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int DoCommand(string query)
        {
            try
            {
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = query;
                int result = objCommand.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public object DoScaler(string query)
        {
            try
            {
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = query;
                object result = objCommand.ExecuteScalar();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable DoSelectProcedure(string name, SqlParameter[] param)
        {
            try
            {
                DataTable table = new DataTable();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = name;
                if (table != null)
                    table.Clear();
                Da.SelectCommand = objCommand;
                objCommand.Parameters.Clear();
                objCommand.Parameters.AddRange(param);
                Da.Fill(table);
                return table;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable DoSelectProcedure(string name)
        {
            try
            {
                DataTable table = new DataTable();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = name;
                if (table != null)
                    table.Clear();
                objCommand.Parameters.Clear();
                Da.SelectCommand = objCommand;
                Da.Fill(table);
                return table;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SqlDataReader DoReader(string query)
        {
            try
            {
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = query;
                SqlDataReader dr = objCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    return dr;
                }
                else
                {
                    return dr;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int ExecuteProcedure(string name, string[] param, object[] value)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = name;
                objCommand.Parameters.Clear();
                for (int i = 0; i < param.Length; i++)
                {
                    objCommand.Parameters.AddWithValue(param[i], value[i]);
                    objCommand.Parameters[i].Size = 4000;
                }
                int result = objCommand.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int ExecuteProcedure(string name, string[] param, ref string[] value, ParameterDirection[] direction)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = name;
                objCommand.Parameters.Clear();
                for (int i = 0; i < param.Length; i++)
                {
                    objCommand.Parameters.AddWithValue(param[i], value[i].ToString());
                    objCommand.Parameters[i].Direction = direction[i];
                    objCommand.Parameters[i].Size = 4000;
                }
                int result = objCommand.ExecuteNonQuery();
                for (int i = 0; i < objCommand.Parameters.Count; i++)
                {
                    value[i] = (objCommand.Parameters[i].Value).ToString();
                }
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public object ExecuteFunction(string name, string[] param, object[] value)
        {
            string query = "";
            try
            {
                objCommand.CommandType = CommandType.Text;
                objCommand.Parameters.Clear();
                for (int i = 0; i < param.Length; i++)
                {
                    objCommand.Parameters.AddWithValue(param[i], value[i]);
                    objCommand.Parameters[i].Size = 4000;
                    query += "'" + value[i].ToString() + "'" + ",";
                }

                string val = "select [dbo]." + "[" + name + "]" + "(" + query + ")";
                objCommand.CommandText = val.Remove(val.Length - 2, 1);
                object result = objCommand.ExecuteScalar();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Disconnect()
        {
            if (objConnection.State != ConnectionState.Closed)
            {
                try
                {
                    objConnection.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                if (objConnection.State == ConnectionState.Closed)
                    return true;
                else
                    return false;
            }
        }        
    }
}
