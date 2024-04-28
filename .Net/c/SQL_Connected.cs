using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectedMySql
{
    class SQL_Connected
    {
        static void Main2(string[] args)
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Snehal\C#_MasterContent\Assignment and Solutions\15_Ado.net\Ass1\ConnectedMySql\MyDb.mdf';Integrated Security=True";//"Server=localhost;Database=emp;Uid=root;Pwd=12345;";
            int id = 10;
            string nm = "Rutu";
            // CREATE
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
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
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM emp";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["empid"].ToString());
                        }
                    }
                }
            }

            // UPDATE
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE emp SET empname = 'Radha' WHERE empid = 3";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record Updated Successfully");
                }
            }

            // DELETE
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM emp WHERE empid = 1";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record Deleted successfully");
                }
            }
        }
    }

}
