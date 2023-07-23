using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class uorder
    {
        private static string my = Properties.Settings.Default.connectionString;
        public string Id { get; set; }
       
        public string Address { get; set; }
        public string Note { get; set; }
        private const string SelectQuery = "Select address as  Address,note asNote,id as Id from Uorder";
        private const string InsertQuery = "Insert Into  Uorder(address,note) Values (@Address,@Note)";
      
        public static DataTable GetUorder()
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(my))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(com))
                    {
                        adp.Fill(data);
                    }
                }
            }
            return data;
        }
        public bool Insertuorder(uorder uo)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(my))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {

                
                    com.Parameters.AddWithValue("@Address", uo.Address);
                    com.Parameters.AddWithValue("@Note", uo.Note);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }


    }


}
