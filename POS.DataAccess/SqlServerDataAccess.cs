using Microsoft.Data.SqlClient;
using POS.Model;
using System.Data;

namespace POS.DataAccess
{
    public class SqlServerDataAccess
    {
        private string ConnStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=new-database;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        
        public int InsertEmployee(Employee employee)
        {
            SqlConnection objSqlConnection = new SqlConnection(ConnStr);
            objSqlConnection.Open();
            
            // string query = $"INSERT INTO tblEmployeev2 (Name ,EmployeeId ,PhoneNumber ,Location)VALUES (Name, varchar(255), EmployeeId, varchar(255),PhoneNumber, varchar(20),Location, varchar(255),)";
            string query = $"INSERT INTO tblEmployeev2 (Name ,EmployeeId ,PhoneNumber ,Location) VALUES ('{employee.Name}', '{employee.EmployeeId}','{employee.PhoneNumber}', '{employee.Location}')";
            
            SqlCommand objSqlCommand = new SqlCommand(query, objSqlConnection);
            objSqlCommand.CommandType = System.Data.CommandType.Text;

            int resultsAffected = objSqlCommand.ExecuteNonQuery();
            if (objSqlConnection.State == System.Data.ConnectionState.Open)
            {
                objSqlConnection.Close();
            }
            return resultsAffected;
        }
        public int DeleteEmployee(Employee employee)
        {
            SqlConnection objSqlConnection = new SqlConnection(ConnStr);
            objSqlConnection.Open();

            // string query = $"INSERT INTO tblEmployeev2 (Name ,EmployeeId ,PhoneNumber ,Location)VALUES (Name, varchar(255), EmployeeId, varchar(255),PhoneNumber, varchar(20),Location, varchar(255),)";
            string query = $"DELETE tblEmployeev2 where Name = '{employee.Name}'";

            SqlCommand objSqlCommand = new SqlCommand(query, objSqlConnection);
            objSqlCommand.CommandType = System.Data.CommandType.Text;

            int resultsAffected = objSqlCommand.ExecuteNonQuery();
            if (objSqlConnection.State == System.Data.ConnectionState.Open)
            {
                objSqlConnection.Close();
            }
            return resultsAffected;
        }
        public int UpdateEmployee(Employee employee)
        {
            SqlConnection objSqlConnection = new SqlConnection(ConnStr);
            objSqlConnection.Open();

            
            string query = $"UPDATE tblEmployeev2 SET  [EmployeeId] = '{employee.EmployeeId}', [PhoneNumber] =  '{employee.PhoneNumber}', [Location] = '{employee.Location}' where [Name] = '{employee.Name}'" ;
            //string query = $"UPDATE tblEmployeev2 SET Name = '{employee.Name}' WHERE Name = '{employee.Name}'"; 
            //string query = $"update StudentTable set LastName='{student.LastName}',Email='{student.Email}',Age='{student.Age}' where FirstName='{student.FirstName}'";
            SqlCommand objSqlCommand = new SqlCommand(query, objSqlConnection);
            objSqlCommand.CommandType = System.Data.CommandType.Text;

            int resultsAffected = objSqlCommand.ExecuteNonQuery();
            if (objSqlConnection.State == System.Data.ConnectionState.Open)
            {
                objSqlConnection.Close();
            }
            return resultsAffected;
        }
        public DataTable FetchEmployee()
        {
            SqlConnection objSqlConnection = new SqlConnection(ConnStr);
            objSqlConnection.Open();



            string query = "SELECT ID,Name,EmployeeId,PhoneNumber,Location FROM tblEmployeev2";



            SqlCommand objSqlCommand = new SqlCommand(query, objSqlConnection);
            objSqlCommand.CommandType = System.Data.CommandType.Text;



            SqlDataAdapter adapter = new SqlDataAdapter(objSqlCommand);
            DataSet dsResults = new DataSet("Information");



            adapter.Fill(dsResults);



            return dsResults.Tables[0];
        }
    }
}
