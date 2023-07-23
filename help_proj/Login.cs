using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        usersss user = new usersss();
        public Login()
        {
            InitializeComponent();
        }
      private void btn_create_acc_Click(object sender, EventArgs e)
        {
            Users_Account fr = new Users_Account();
            fr.Show();
            this.Hide();      
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
           // BorderRe
        }
        private void btn_login_Click(object sender, EventArgs e)
        {          
                if (txt_User_Name.Text.Length > 0)
                {
                    if (txt_Password.Text.Length > 0)
                    {
                        try
                        {

                            int type_user = user.login(txt_User_Name.Text, txt_Password.Text);
                            MessageBox.Show(type_user.ToString());
                            if (type_user == 1)//1 admin user
                            {
                                MessageBox.Show("Helow, welcom to the Admin account");
                                AdminAccount ad = new AdminAccount();
                                ad.Show();
                                this.Hide();
                            }

                            else if (type_user == 0)//0 employee user
                            {
                                MessageBox.Show("Helo,welcom to the Employee account");
                                EmployeeJob em = new EmployeeJob();
                                em.Show();
                                this.Hide();
                            }
                            else if (type_user == 2)//0 employee user
                            {
                                MessageBox.Show("Helo,welcom to the Details Order");
                                DetailsOrder em = new DetailsOrder();
                                em.Show();
                                this.Hide();
                            }
                            else if (type_user == -1)//-1 customer user
                            {

                                MessageBox.Show("Helow,welcom to the services's HS ");
                                show_ us = new show_();
                                us.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Error:The username and passowred is not correct,please try again." + "And if you do not have account please, create account first.");
                            }
                        }


                        catch
                        {
                            MessageBox.Show("Error Conection");
                        }
                    }


                    else
                    {
                        MessageBox.Show("please enter the password");
                    }
                }
                else
                {
                    MessageBox.Show("please enter the user name");
                }
            }
        
        
        //Cheak Box to show the passowerd 

        private void chl_box_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_box.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else {

                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure");
            this.Close();
        }
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
        }
      
        private void UseLetterOnly(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'Q':case 'q':case 'A':case 'a':case 'X':case 'x':
                case 'W':case 'w':case 'S':case 's':case 'C':case 'c':
                case 'E':case 'e':case 'D':case 'd':case 'V':case 'v':
                case 'R':case 'r':case 'F':case 'f':case 'B':case 'b':
                case 'T':case 't':case 'G':case 'g':case 'N':case 'n':
                case 'Y':case 'y':case 'H':case 'h':case 'M':case 'm':
                case 'U':case 'u':case 'J':case 'j':case (char)Keys.Space:
                case 'I':case 'i':case 'K':case 'k':
                case 'O':case 'o':case 'L':case 'l':
                case 'P':case 'p':case 'Z':case 'z':
                case (char)Keys.Back:
                    e.Handled = false;
                    break;
                default:
                    MessageBox.Show("Please enter Letter only.You use:"+e.KeyChar);
                    e.Handled = true;
                    break;
            }
        }
        private void txt_User_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            UseLetterOnly(e);

        }
        private void UseNumberOnly(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':case  (char)Keys.Enter:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case (char)Keys.Back:
                    e.Handled = false;
                    break;
                default:
                    MessageBox.Show("Please enter Number only.You use:"+e.KeyChar);
                    e.Handled = true;
                    break;
            }
        }
        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            UseNumberOnly(e);

        }
        private void but_min_Click(object sender, EventArgs e)
        {
            //this.MinimumSize = new Size(300, 200);
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Form_closing(object sender, FormClosingEventArgs e)
        {
        }
        private void but_max_Click(object sender, EventArgs e)
        {
            // this.MaximumSize =new Size(500, 200);
        }

    }
}
