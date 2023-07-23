using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class usersss
    {
        String myconn = Properties.Settings.Default.connectionString;

        public String Id { get; set; }
        public String user_name { get; set; }
        public String u_pass { get; set; }
        public String re_pass { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
     

        private String Insert = "insert into USERS(user_name,u_pass,re_pass,email,phone,type_user) values(@user_name,@u_pass,@re_pass,@email,@phone,-1)";


        public bool insert_user(usersss user)
        {
                SqlConnection con = new SqlConnection(myconn);
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Insert, con))
                {
                    cmd.Parameters.AddWithValue("@user_name", user.user_name);
                    cmd.Parameters.AddWithValue("@u_pass", user.u_pass);
                    cmd.Parameters.AddWithValue("@re_pass", user.re_pass);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@phone", user.phone);

                    return (cmd.ExecuteNonQuery() > 0);

                }
            }            
      
        
                
        public int login(String usr_name, String pass)
        {
            int type_user = -1;
            String select = "select * from USERS where user_name=" + "'" + usr_name+"'"+" and u_pass="+"'"+pass+"'";
            SqlConnection con = new SqlConnection(myconn);
            con.Open();
            SqlCommand cmd = new SqlCommand(select,con);

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    type_user = Convert.ToInt32(rd["type_user"]);
                }
            }
            else

            {
                type_user = 3;
            }
            return type_user;//-1 mean customer user ,0 mean employee user,,1 mean admin user,2 do not fuond
        }
    }
}
    
