using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Adminn
    {
        private static string myconn = Properties.Settings.Default.connectionString;
        public string Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeJob { get; set; }
        public string EmployeeSalary { get; set; }

        private const string selectQuery = "select id as ID, employee_name as Employee_Name,employee_phone as Employee_Phone,employee_address as Employee_Address, employee_city as Employee_City, employee_job as Employee_Job, employee_salary as Employee_Salary  from Adminnn";
        private const string InsertQuery = "Insert Into Adminnn (employee_name,employee_phone,employee_address,employee_city,employee_job,employee_salary) Values (@Employee_Name,@Employee_Phone,@Employee_Address,@Employee_City,@Employee_Job,@Employee_Salary)";
        private const string UpdateQuery = "Update Adminnn set employee_name=@Employee_Name,employee_phone=@Employee_Phone,employee_address=@Employee_Address,employee_city=@Employee_City,employee_job=@Employee_Job,employee_salary=@Employee_Salary where id = ID";
        private const string DeleteQuery = "Delete from Adminnn where id=@ID";

        public static DataTable GetAdminnn()
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(selectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }
        public bool InsertAdminn(Adminn admin)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@Employee_Name", admin.EmployeeName);
                    com.Parameters.AddWithValue("@Employee_Phone", admin.EmployeePhone);
                    com.Parameters.AddWithValue("@Employee_Address", admin.EmployeeAddress);
                    com.Parameters.AddWithValue("@Employee_City",admin.EmployeeCity);
                    com.Parameters.AddWithValue("@Employee_Job", admin.EmployeeJob);
                    com.Parameters.AddWithValue("@Employee_Salary", admin.EmployeeSalary);
                    rows = com.ExecuteNonQuery();

                }
            }
            return (rows > 0) ? true : false;
        }
        public bool UpdateAdminn(Adminn admin)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@Id", admin.Id);
                    com.Parameters.AddWithValue("@Employee_Name", admin.EmployeeName);
                    com.Parameters.AddWithValue("@Employee_Phone", admin.EmployeePhone);
                    com.Parameters.AddWithValue("@Employee_Address", admin.EmployeeAddress);
                    com.Parameters.AddWithValue("@Employee_City", admin.EmployeeCity);
                    com.Parameters.AddWithValue("@Employee_Job", admin.EmployeeJob);
                    com.Parameters.AddWithValue("@Employee_Salary", admin.EmployeeSalary);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public bool DeleteAdminn(Adminn admin)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@Id", admin.Id);
                    
                    rows = com.ExecuteNonQuery();

                }
            }
            return (rows > 0) ? true : false;
        }
        
            
    }
}
