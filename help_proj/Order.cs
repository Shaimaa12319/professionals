using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    class Order
    {
        private static string setting = Properties.Settings.Default.connectionString;
        public string Id { get; set; }
        public string LaborName { get; set; }
        public string OrderType { get; set; }
        public int OrderNum { get; set; }
        public DateTime OrderDate { get; set; }
        public string NameCustomer{ get; set; }
        public string OrderNote { get; set; }
        private const string SelectQuery = "Select  id as ID,labor_name as LaborName,order_type as OrderType,order_num as OrderNumber, order_date as OrderDate,name_customer as NameCustomer,order_note as OrderNote From Orders";
        private const string InsertQuery = "Insert Into Orders(labor_name,order_type,order_num,order_date,name_customer,order_note) Values (@LaborName,@OrderType,@OrderNum,@OrderDate,@NameCustomer,@OrderNote)";
        private const string UpdateQuery = "Update Orders set labor_name=@LaborName,order_type=@OrderType,order_num=@OrderNum,order_date=@OrderDate,name_customer=@NameCustomer,order_note=@OrderNote where Id=@Id";
        private const string DeleteQuery = "Delete From Orders where id=@Id";

        public static DataTable GetOrders()
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(setting))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }
        public bool InsertOrder(Order ord)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(setting))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))

                {
                  
                    com.Parameters.AddWithValue("@LaborName",ord.LaborName);
                    com.Parameters.AddWithValue("@OrderType",ord.OrderType);
                    com.Parameters.AddWithValue("@OrderNum",ord.OrderNum);
                    com.Parameters.AddWithValue("@OrderDate",ord.OrderDate);
                    com.Parameters.AddWithValue("@NameCustomer", ord.NameCustomer);
                    com.Parameters.AddWithValue("@OrderNote", ord.OrderNote);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public bool UpdateOrder(Order ord)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(setting))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@Id", ord.Id);
                    com.Parameters.AddWithValue("@LaborName", ord.LaborName);
                    com.Parameters.AddWithValue("@OrderType", ord.OrderType);
                    com.Parameters.AddWithValue("@OrderNum", ord.OrderNum);
                    com.Parameters.AddWithValue("@OrderDate", ord.OrderDate);
                    com.Parameters.AddWithValue("@NameCustomer", ord.NameCustomer);
                    com.Parameters.AddWithValue("@OrderNote", ord.OrderNote);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public bool DeleteOrder(Order ord)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(setting))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@Id", ord.Id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }


    }
}
