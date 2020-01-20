using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShredShop
{
    public class Database
    {
        protected string connectionString;
        protected Random rand = new Random();

        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool TryLogin(string user, string pass)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT email FROM Users WHERE UserName = @username AND Password = @password", con);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@password", pass);

            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);

            int count = ds.Tables[0].Rows.Count;
            con.Close();

            if (count == 1)
                return true;
            else
                return false;
        }

        public bool CheckDuplicateUsername(string user)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT UserName FROM Users WHERE UserName = @username", con);
            cmd.Parameters.AddWithValue("@username", user);

            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);

            int count = ds.Tables[0].Rows.Count;
            con.Close();

            if (count == 1)
                return true;
            else
                return false;
        }

        public bool DoRegister(string user, string pass, string email)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@id, @username, @password, @email)", con);
            int id = rand.Next(10000, 99999);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Parameters.AddWithValue("@email", email);

            con.Open();

            int result = cmd.ExecuteNonQuery();
            con.Close();

            if (result == 1)
                return true;
            else
                return false;
        }

        public string[] GetProduct(int itemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT ItemName, Catogory, Price FROM Products WHERE ItemID = @itemID", con);
            cmd.Parameters.AddWithValue("@itemID", itemID);

            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);

            string[] ret = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int price = (int)row["Price"];
                ret = new string[] { (string)row["ItemName"], (string)row["Catogory"], price.ToString() };
            }
            con.Close();

            return ret;
        }
    }
}
