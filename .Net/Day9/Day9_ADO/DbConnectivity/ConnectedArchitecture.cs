using MySqlConnector;

namespace DbConnectivity
{
    internal class ConnectedArchitecture
    {
        static void Main_1(string[] args)
        {
            //DisplayData
            // DisplayData();

            //InsertData()
            // InsertData();

            //UpdateData();
            //DeleteData();

            //Scaler
            TotalEmp();

        }
        private static void TotalEmp()
        {
            //Step1: 
            string str = "Server=localhost;userid=root;password=12345;database=empdb";

            //Step2:
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done...");
                string query = "Select Count(*) from emp ";
                //Step 3
                MySqlCommand cmd = new MySqlCommand(query, conn);
                

                //Step 4
                dynamic res = cmd.ExecuteScalar();
                Console.WriteLine(res + " Record Present in Database!");
                //Step 5
                conn.Close();

            }
        }
        private static void DeleteData()
        {
            //Step1: 
            string str = "Server=localhost;userid=root;password=12345;database=empdb";

            //Step2:
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done...");
                string query = "Delete from emp where Id=@id";
                //Step 3
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", 5);
                
                //Step 4
                int res = cmd.ExecuteNonQuery();
                Console.WriteLine(res + " Record Deleted Successfully!");
                //Step 5
                conn.Close();

            }
        }
        private static void UpdateData()
        {
            //Step1: 
            string str = "Server=localhost;userid=root;password=12345;database=empdb";

            //Step2:
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done...");
                string query = "update emp set Ename=@name ,Salary =@sal where Id=@id";
                //Step 3
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", 5);
                cmd.Parameters.AddWithValue("@name", "Shubham");
                cmd.Parameters.AddWithValue("@sal", 7000.67f);
               

                //Step 4
                int res = cmd.ExecuteNonQuery();
                Console.WriteLine(res + " Record Updated Successfully!");
                //Step 5
                conn.Close();

            }
        }
        private static void InsertData()
        {
            //Step1: 
            string str = "Server=localhost;userid=root;password=12345;database=empdb";

            //Step2:
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done...");
                string query = "insert into emp values(@id,@name,@sal,@add)";
                //Step 3
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", 5);
                cmd.Parameters.AddWithValue("@name", "Vivek");
                cmd.Parameters.AddWithValue("@sal", 5000.67f);
                cmd.Parameters.AddWithValue("@add", "Aurangabad");

                //Step 4
                int res = cmd.ExecuteNonQuery();
                Console.WriteLine(res+ " Record Inserted Successfully!");
                //Step 5
                conn.Close();

            }
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
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1) + " " + reader.GetFloat(2) + " " + reader.GetString(3));
                }
                //Step 5
                conn.Close();

            }
        }
    }
}
