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
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class DetailsOrder : Form
    {
        Order ord = new Order();
        public DetailsOrder()
        {
            InitializeComponent();
            dgv_user_info.DataSource = Order.GetOrders();
        }
        private void DetailsOrder_Load(object sender, EventArgs e)
        {
             txt_labor_name.Text = "Select your labor name:";
             txt_labor_name.Items.AddRange(new string[] { "Ahmad", "Mohammed", "Aezzaldeen", "Fwaz", "Rshad", "Hashm", "Adnan", "Rsha" });
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                ord.LaborName = txt_labor_name.Text;
                ord.OrderType = txt_order_type.Text;
                ord.OrderNum = Convert.ToInt32(mas_ph.Text);
                ord.OrderDate = dtp_order_date.Value;
                ord.NameCustomer = txt_name_coustomer.Text;
                ord.OrderNote = txt_order_note.Text;
                //call
                bool success = ord.InsertOrder(ord);
                //refresh
                dgv_user_info.DataSource = Order.GetOrders();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show(@"Order has been added successfully");
                }
                else
                {
                    MessageBox.Show(@"Error occured. Please try again...");
                }
            }
        }
        private bool isValid()
        {
            if (txt_labor_name.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid labor name please!", "Error");
                return false;
            }
            else if (txt_order_type.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Order please!", "Error");
                return false;
            }
            else if (mas_ph.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Phone Labor please!" + "It is Empty ", "Error");
                return false;
            }
            else if (dtp_order_date.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Date please!", "Error");
                return false;
            }
            else if (txt_name_coustomer.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Order Customer please!", "Error");
                return false;
            }
            else if (txt_order_note.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Order Note please!", "Error");
                return false;
            }

            return true;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            ord.Id = lab_id.Text;
            ord.LaborName = txt_labor_name.Text;
            ord.OrderType = txt_order_type.Text;
            ord.OrderNum = Convert.ToInt32( mas_ph.Text );
            ord.OrderDate = dtp_order_date.Value;
            ord.NameCustomer = txt_name_coustomer.Text;
            ord.OrderNote = txt_order_note.Text;
            //call
            var success = ord.UpdateOrder(ord);
            
                dgv_user_info.DataSource = Order.GetOrders();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show(@"Order has been Updated successfully");
                }
                else
                
                    MessageBox.Show(@"Error occured. Please try again...");
                }

        private void but_delete_Click(object sender, EventArgs e)
        {
            ord.Id = lab_id.Text;
            ord.LaborName = txt_labor_name.Text;
            //call
            var success = ord.DeleteOrder(ord);
                dgv_user_info.DataSource=Order.GetOrders();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show(@"Order has been delete succcessfully");

                }
                else
                    MessageBox.Show(@"Error occured. Please try again ...");
                }
        private void but_clear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            foreach (Control control in pa_1.Controls)
              
            {
                control.Text = "";
            }
        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dgv_user_info.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, pa_controls.Text);
            }
        }

        private void exitFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void DetailsOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            e.Cancel = (result == DialogResult.No);
        }

        private void but_Back_Click(object sender, EventArgs e)
        {
            EmployeeJob em = new EmployeeJob();
            em.Show();
        }

        private void dgv_user_info_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            lab_id.Text = dgv_user_info.Rows[index].Cells[0].Value.ToString();
            txt_labor_name.Text = dgv_user_info.Rows[index].Cells[1].Value.ToString();
            txt_order_type.Text = dgv_user_info.Rows[index].Cells[2].Value.ToString();
            mas_ph.Text = dgv_user_info.Rows[index].Cells[3].Value.ToString();           
            txt_name_coustomer.Text = dgv_user_info.Rows[index].Cells[6].Value.ToString();
            txt_order_note.Text = dgv_user_info.Rows[index].Cells[4].Value.ToString();

        }
        private void label12_Click(object sender, EventArgs e)
        {
        }
        private void txt_labor_name_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txt_order_date_TextChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void dgv_user_info_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void txt_order_note_TextChanged(object sender, EventArgs e)
        {
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
