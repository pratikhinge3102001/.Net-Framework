using System;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedMySql
{
    

    class SQL_DisconnectedProgram
    {
        static void Main2(string[] args)
        {
            // string connString = "Server=localhost;Database=emp;Uid=root;Pwd=12345;";
            // string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Snehal\C#_MasterContent\Assignment and Solutions\15_Ado.net\Ass1\ConnectedMySql\MyDb.mdf';Integrated Security=True";

            string connString= System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            // CREATE
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO emp (empid, empname) VALUES (@value1, @value2)";
                cmd.Parameters.AddWithValue("@value1", 19);
                cmd.Parameters.AddWithValue("@value2", "ssRam1");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.InsertCommand = cmd;
                    adapter.InsertCommand.ExecuteNonQuery();
                    Console.WriteLine("Inserted Sucessfully");
                }
            }

            // READ
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM emp";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Console.WriteLine();
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine(row["empid"].ToString() +"  "+ row["empname"].ToString());
                    }
                }
            }

            // UPDATE
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE emp SET empname = @newValue WHERE empid = @id";
                cmd.Parameters.AddWithValue("@newValue", "new value");
                cmd.Parameters.AddWithValue("@id", 1);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.UpdateCommand = cmd;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    Console.WriteLine("Updated Sucessfully");
                }
            }

            // DELETE
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM emp WHERE empid = @id";
                cmd.Parameters.AddWithValue("@id", 4);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.DeleteCommand = cmd;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    Console.WriteLine("Deleted Sucessfully");
                }
            }
        }
    }

}
