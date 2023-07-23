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
    public partial class OrderUsers : Form
    {
        uorder uo = new uorder();
        public OrderUsers()
        {
            InitializeComponent();
           
        }

        private void btn_send_Click_1(object sender, EventArgs e)
        {

            if (txb_Address.Text.Length > 0)
            {
                if (txb_note.Text.Length > 0)
                {
                    try
                    {
                        uo.Address = txb_Address.Text;
                        uo.Note = txb_note.Text;
                        bool success = uo.Insertuorder(uo);
                        if (success)
                        {
                            MessageBox.Show(@"your order has been send successfully");
                        }
                        else
                        {
                            MessageBox.Show(@"Error occured.Please try again..");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Eroor Conection");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the note about your problem you have");
                }
            }


                else
                {
                    MessageBox.Show("Please enter your address");
                }

            }
     

        private void btn_back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will back to the show sevices form");
            show_ sh = new show_();
            sh.Show();
            this.Hide();

        }

        private void dgv_info_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void com_services_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void com_sp_services_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void frm_order_Load(object sender, EventArgs e)
        {
        }
        private void frm_order_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void txb_Address_TextChanged(object sender, EventArgs e)
        {
        }
        private void txb_note_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
