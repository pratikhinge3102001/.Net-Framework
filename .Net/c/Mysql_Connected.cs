using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySqlConnector;
namespace ConnectedMySql
{
    class Program_Connected
    {
        static void Main1(string[] args)
        {
            string connString = "Server=localhost;Database=emp;Uid=root;Pwd=12345;";
            int id = 10;
            string nm = "Rutu";
            // CREATE
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO emp (empid, empname) VALUES (@id, @nm)";
                    cmd.Parameters.AddWithValue("@id",id);
                    cmd.Parameters.AddWithValue("@nm",nm);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record Insert Successfully");
                }
            }

            // READ
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM emp";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["empid"].ToString());
                        }
                    }
                }
            }

            // UPDATE
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE emp SET empname = 'Radha' WHERE empid = 3";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record Updated Successfully");
                }
            }

            // DELETE
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM emp WHERE empid = 1";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record Deleted successfully");
                }
            }

            //Ass4: Display No of employees present in Emp Table . (Use Connected archeture and ExecuteScaler Method)
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select count(*) from  emp ";
                    int res =(int) cmd.ExecuteScalar();
                    Console.WriteLine("Total Record : "+res);
                }
            }

        }
    }

}
