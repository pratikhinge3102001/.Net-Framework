using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectivity
{
    internal class DisconnectedDemo
    {
        static void Main(string[] args)
        {
            DisplayData();
        }
        private static void DisplayData()
        {
            //Step1: 
            string str = "Server=localhost;userid=root;password=12345;database=empdb";

            //Step2:
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done...");
                string query = "Select * from emp";
                //Step 3
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Step 4
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //For DataTable
                // DataTable dt = new DataTable();
                // adapter.Fill(dt);

                //For DataSet
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                //For Datatable
                //dt.Rows
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    Console.WriteLine(item[0].ToString() + " " + item[1].ToString() + " " + item[2].ToString() + " " + item[3].ToString()) ;
                }

                //Step 5
                conn.Close();

            }
        }
    }
}
