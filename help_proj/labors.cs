using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    class labors
    {
        private static string mycoon = Properties.Settings.Default.connectionString;
        public string Id { get; set; }
        public string Labor_Name { get; set; }
        public int Labor_Phone { get; set; }
        public string Labor_Job { get; set; }
        public string LaborEmail { get; set; }
        public string LaborCity { get; set; }
        public string Labor_Salary { get; set; }

        private const string SelectQuery = "select id as ID, labor_name as Labor_Name, labor_phone as Labor_Phone, labor_job as Labor_Job, labor_email as LaborEmail, labor_city as LaborCity ,labor_salary as Labor_Salary from Labor";
        private const string InsertQuery = "Insert Into Labor(labor_name, labor_phone, labor_job, labor_email, labor_city, labor_salary) Values (@Labor_Name,@Labor_Phone,@Labor_Job,@LaborEmail,@LaborCity,@Labor_Salary)";
        private const string UpdateQuery = "Update Labor set labor_name=@Labor_Name,labor_phone=@Labor_Phone,labor_job=@Labor_Job,labor_email=@LaborEmail,labor_city=@LaborCity, labor_salary=@Labor_Salary  where id=@ID";
        private const string DeleteQuery = "Delete from Labor where id=@ID";

        public static DataTable Getlabor()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(mycoon))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public bool Insertlabors(labors la)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(mycoon))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                 
                   
                    com.Parameters.AddWithValue("@Labor_Name", la.Labor_Name);
                    com.Parameters.AddWithValue("@Labor_Phone", la.Labor_Phone);
                    com.Parameters.AddWithValue("@Labor_Job", la.Labor_Job);
                    com.Parameters.AddWithValue("@LaborEmail", la.LaborEmail);
                    com.Parameters.AddWithValue("@LaborCity", la.LaborCity);
                    com.Parameters.AddWithValue("@Labor_Salary", la.Labor_Salary);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;


        }

        public bool Updatelabors(labors la)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(mycoon))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery,con))
                {
                    com.Parameters.AddWithValue("@Id", la.Id);
                    com.Parameters.AddWithValue("@Labor_Name",la.Labor_Name);
                    com.Parameters.AddWithValue("@Labor_Phone",la.Labor_Phone);
                    com.Parameters.AddWithValue("@Labor_Job",la.Labor_Job);
                    com.Parameters.AddWithValue("@LaborEmail",la.LaborEmail);
                    com.Parameters.AddWithValue("@LaborCity",la.LaborCity);
                    com.Parameters.AddWithValue("@Labor_Salary", la.Labor_Salary);
                    rows = com.ExecuteNonQuery();
                }

            }
            return (rows > 0) ? true : false;


        }
        public bool Deletelabors(labors la)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(mycoon))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@Id", la.Id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}
