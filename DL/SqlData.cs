using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class SqlData
    {
        static string connectionString
        = "Data Source=LAPTOP-BIQEJS21;Initial Catalog=CMS;User ID=clark;Password=clark123";

        static SqlConnection sqlConnection = new SqlConnection(connectionString);

       
        static public string DisplayCourierData()
        {
            var selectStatement = "select * from dbo.Table_1";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Name: {reader["Name"]}");
                Console.WriteLine($"ID: {reader["ID"]}");
                Console.WriteLine($"Contact: {reader["Contact"]}");
                Console.WriteLine();
            }
            var showCourier = reader.Read().ToString();
            sqlConnection.Close();
            return showCourier;
        }

        static public string CreateAnAccount(string name, string id, int contact)
        {
            var insertStatement = "INSERT INTO dbo.Table_1 (Name, ID, Contact) VALUES (@Name, @ID, @Contact)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);
            

            insertCommand.Parameters.AddWithValue("@Name",name);
            insertCommand.Parameters.AddWithValue("@ID",id);
            insertCommand.Parameters.AddWithValue("@Contact",contact);

            sqlConnection.Open();
            SqlDataReader reader = insertCommand.ExecuteReader();
            var createAnAccount = reader.Read().ToString();
            sqlConnection.Close();
            return createAnAccount;
            



        }
    }
}
