using System.Configuration;

namespace DataAccessLayer
{
    public class ConnectionString
    {
        public ConnectionString()
        {
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings[0].ToString();
        }
    }
}