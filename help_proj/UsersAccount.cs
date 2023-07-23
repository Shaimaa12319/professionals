using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Users_Account : Form
    {
       
        usersss user = new usersss();

        public Users_Account()
        {
            InitializeComponent();

        }
        void clear_controls()
        {
            txt_User_Name.Text = "";
            txt_password.Text = "";
            txb_RePassowrd.Text = "";
           txt_Email.Text = "";
            txt_ph.Text = "";
        }

        private void control_Validating(object sender, CancelEventArgs e)
        {

            String error = null;
            if (((Control)sender).Text.Trim().Length == 0)
            {
                error = "This field is required!";
                e.Cancel = true;
            }
            errorProvider1.SetError((Control)sender, error);
        }

        private void txb_RePassowrd_Validating(object sender, CancelEventArgs e)
        {
            control_Validating(sender, e);
            String error = null;
            if (txb_RePassowrd.Text != txb_RePassowrd.Text)
            {
                error = "Password and Re-enter Password must be the same!";
                e.Cancel = true;

            }
            errorProvider1.SetError((Control)sender, error);
        }

        private void txt_Email_Validating(object sender, CancelEventArgs e)
        {
            control_Validating(sender, e);
            String error = null;
            try
            {
                new MailAddress(txt_Email.Text);
            }
            catch (Exception)
            {
                error = "Please use a valid format email!";
                e.Cancel = true;
            }
            errorProvider1.SetError((Control)sender, error);
        }
        private void txt_ph_Validating(object sender, CancelEventArgs e)
        {
            control_Validating(sender, e);
            String error = null;
            if (txt_ph.Text != txt_ph.Text)
            {
                error = "phone numbeer must be the same!";
                e.Cancel = true;

            }
            errorProvider1.SetError((Control)sender, error);
        }
   

        private void User_Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            e.Cancel = (result == DialogResult.No);
        }

        private void btn_Sign_up_Click(object sender, EventArgs e)
        {
           
                user.user_name = txt_User_Name.Text;
                user.u_pass = txt_password.Text;
                user.re_pass = txb_RePassowrd.Text;
                user.email = txt_Email.Text;
                user.phone = txt_ph.Text;

                if (user.insert_user(user))
                {
                    MessageBox.Show("completed corectly.Now we will move you to login form  to insert your name and passwored.To move you to the services page");
                    Login lo = new Login();
                    lo.Show();
                    this.Hide();
                    clear_controls();
                }
                else
                {
                    MessageBox.Show("faild completed");
                }
        }
       
                 
        private void UseLetterOnly(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'Q':case 'q':case 'R':case 'r':  case (char)Keys.Space:             
                case 'A':case 'a':case 'F':case 'f':               
                case 'X':case 'x':case 'B':case 'b':             
                case 'W':case 'w':case 'T':case 't':               
                case 'S':case 's':case 'G':case 'g':               
                case 'C':case 'c': case'N':case 'n':               
                case 'E':case 'e':case 'Y':case 'y':                
                case 'D':case 'd':case 'H':case 'h':               
                case 'V':case 'v':case 'M':case 'm':                                                                                                                                        
                case 'U':case 'u':case 'J':case 'j':               
                case 'I':case 'i':case 'K':case 'k':                
                case 'O':case 'o':case 'L':case 'l':               
                case 'P':case 'p':case 'Z':case 'z':
                
                case (char)Keys.Back:
                    e.Handled = false;
                    break;
                default:
                    MessageBox.Show("Please enter Letter only.You Use:"+e.KeyChar);
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
                       case '0':
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
                           MessageBox.Show("Please enter Number only.You Use:"+e.KeyChar);
                           e.Handled = true;
                           break;
                   }
               }

               private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
               {
                   UseNumberOnly(e);
               }
               private void txt_ph_KeyPress(object sender, KeyPressEventArgs e)
               {
                   UseNumberOnly(e);
               }
               private void but_back_Click(object sender, EventArgs e)
               {
                   MessageBox.Show("Back to the login form!");
                   Login lo = new Login();
                   lo.Show();
                   this.Hide();
               }


        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void btn_Sign_In_Click(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void com_city_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txt_ph_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_Address_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
        }
        private void frm_create_acc_Load(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void txt_user_namee_TextChanged(object sender, EventArgs e)
        {
        }
       
    }
    }

