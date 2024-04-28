using ActionsAndModel.Models;
using MySqlConnector;

namespace ActionsAndModel.DAL
{
    public class EmpDbMethods
    {
        public int InsertEmp(Employee employee)
        {
            int res = 0;
            string con = "Server=localhost;userid=root;password=12345;database=empdb";
            using (MySqlConnection conConn = new MySqlConnection(con))
            {
                try
                {
                    conConn.Open();
                    string Query = "Insert into emp values(@email,@name,@job,@sal)";
                    MySqlCommand cmd = new MySqlCommand(Query, conConn);
                    cmd.Parameters.AddWithValue("@email", employee.Id);
                    cmd.Parameters.AddWithValue("@name", employee.Name);
                    cmd.Parameters.AddWithValue("@job", employee.Salary);
                    cmd.Parameters.AddWithValue("@sal", employee.Address);
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }

            }
            return res;


        }
    }
}
