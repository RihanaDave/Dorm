using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class AddressBook
    {
        DataAccess DAL;

        public AddressBook()
        {
            DAL = new DataAccess();
        }

        public DataTable ShowData(string value)
        {
            SqlParameter[] p = { new SqlParameter("UserID", value) };
            DAL.Connect();
            DataTable result = DAL.DoSelectProcedure("AddressBookShowData", p);
            DAL.Disconnect();
            return result;
        }

        public int Insert(string UserID, string Name, string Family, string Company, string Tel1, string Tel2, string Tel3,string Fax,string Email,string URL,string Address,string Description)
        {
            string[] p = { "UserID", "name", "family", "company", "tel1", "tel2", "@tel3", "fax", "email", "url", "address", "description" };
            string[] v = { UserID, Name, Family, Company, Tel1, Tel2, Tel3, Fax, Email, URL, Address, Description };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("AddressBookInsert", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Edit(string AddressBookID, string UserID, string Name, string Family, string Company, string Tel1, string Tel2, string Tel3, string Fax, string Email, string URL, string Address, string Description)
        {
            string[] p = { "AddressBookID", "UserID", "name", "family", "company", "tel1", "tel2", "@tel3", "fax", "email", "url", "address", "description" };
            string[] v = { AddressBookID, UserID, Name, Family, Company, Tel1, Tel2, Tel3, Fax, Email, URL, Address, Description };
            DAL.Connect();
            int result = DAL.ExecuteProcedure("AddressBookEdit", p, v);
            DAL.Disconnect();
            return result;
        }

        public int Delete(string AddressBookID)
        {
            string[] p = { "AddressBookID" };
            string[] v = {  AddressBookID};
            DAL.Connect();
            int result = DAL.ExecuteProcedure("AddressBookDelete", p, v);
            DAL.Disconnect();
            return result;
        }
    }
}
