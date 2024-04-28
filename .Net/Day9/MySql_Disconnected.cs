using System;
using System.Data;
using MySqlConnector;
using System.Configuration;

namespace ConnectedMySql
{
   class Program
    {
        static void Main(string[] args)
        {
            //string connString = "Server=localhost;Database=emp;Uid=root;Pwd=12345;";
            string connString= ConfigurationManager.ConnectionStrings["MyMySQLConnection"].ConnectionString;
            // CREATE
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO emp (empid, empname) VALUES (@value1, @value2)";
                cmd.Parameters.AddWithValue("@value1", 15);
                cmd.Parameters.AddWithValue("@value2", "Ram1Sitalax");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.InsertCommand = cmd;
                    adapter.InsertCommand.ExecuteNonQuery();
                    Console.WriteLine("Inserted Sucessfully");
                    conn.Close();
                }
            }

            // READ
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM emp";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
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
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE emp SET empname = @newValue WHERE empid = @id";
                cmd.Parameters.AddWithValue("@newValue", "new value");
                cmd.Parameters.AddWithValue("@id", 1);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.UpdateCommand = cmd;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    Console.WriteLine("Updated Sucessfully");
                }
            }

            // DELETE
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM emp WHERE empid = @id";
                cmd.Parameters.AddWithValue("@id", 4);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.DeleteCommand = cmd;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    Console.WriteLine("Deleted Sucessfully");
                }
            }
			
			
			//Insert, Update, and Delete operations using a disconnected architecture in ADO.NET:

//Insert:
using (SqlConnection connection = new SqlConnection("connection string"))
{
    // Create a DataSet and DataTable
    DataSet ds = new DataSet();
    DataTable dt = new DataTable("Customers");

    // Add columns to the DataTable
    dt.Columns.Add("CustomerID", typeof(int));
    dt.Columns.Add("Name", typeof(string));
    dt.Columns.Add("City", typeof(string));

    // Add a new row to the DataTable
    DataRow newRow = dt.NewRow();
    newRow["CustomerID"] = 1234;
    newRow["Name"] = "New Customer";
    newRow["City"] = "Pune";
    dt.Rows.Add(newRow);

    // Create a DataAdapter
    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", connection);

    // Open the connection
    connection.Open();

    // Fill the DataSet with existing data (optional, for reference)
    da.Fill(ds, "Customers");

    // Add the new row to the DataSet
    ds.Tables["Customers"].Rows.Add(newRow);

    // Update the database with the changes
    da.Update(ds, "Customers");
}

//Update:

using (SqlConnection connection = new SqlConnection("connection string"))
{
    // Fetch existing data into a DataSet
    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Customers");

    // Modify a row in the DataSet
    DataRow rowToUpdate = ds.Tables["Customers"].Rows[0]; // Assuming you want to update the first row
    rowToUpdate["City"] = "London";

    // Update the database with the changes
    da.Update(ds, "Customers");
}

//Delete:
using (SqlConnection connection = new SqlConnection("connection string"))
{
    // Fetch existing data into a DataSet
    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Customers");

    // Mark a row for deletion in the DataSet
    DataRow rowToDelete = ds.Tables["Customers"].Rows[0]; // Assuming you want to delete the first row
    rowToDelete.Delete();

    // Update the database with the changes (including deletion)
    da.Update(ds, "Customers");
}
        }
    }

}
