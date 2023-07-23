using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class EmployeeJob : Form
    {
        labors la = new labors();
        public EmployeeJob()
        {
            InitializeComponent();
            dgv_labors_info.DataSource = labors.Getlabor();
        }

        private void EmployeeJob_Load(object sender, EventArgs e)
        {

            com_city.Text = "Select your city:";
            com_city.Items.AddRange(new string[] { "Sana'a", "Aden", "Ibb", "Taiz", "Hadramoot", "Hodedah", "Albedaa", "Rdaa" });
            lis_labor_job.ValueMember = "value";
            lis_labor_job.DisplayMember = "Key";
            lis_labor_job.DataSource=new KeyValuePair<string,int>[]
            {     
                 new KeyValuePair<string,int  >("Teacher",1),
                 new KeyValuePair<string,int  >("Macanich",2),
                 new KeyValuePair<string,int  >("Electricain",3),
                 new KeyValuePair<string,int  >("Plumbing",4),
                 new KeyValuePair<string,int  >("Capentry",5),
                 new KeyValuePair<string,int  >("Blacksmith",6),
                 
            };
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            foreach (Control control in pan_Control.Controls)
            {
                control.Text = "";
            }
        }
        private void but_add_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                la.Labor_Name = txt_labor_name.Text;
                la.Labor_Phone = Convert.ToInt32(mas_labor_phone.Text);
                la.Labor_Job = lis_labor_job.Text;
                la.LaborEmail = txt_labor_email.Text;
                la.LaborCity = com_city.Text;
                la.Labor_Salary = txt_salary.Text;

                //call insert 

                bool success = la.Insertlabors(la);

                //Referesh

                dgv_labors_info.DataSource = labors.Getlabor();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show(@"labor has been added successfully");

                }
                else
                {
                    MessageBox.Show(@"error occured. please try again...");
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
            else if (mas_labor_phone.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Phone please!", "Error");
                return false;
            }
            else if (lis_labor_job.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Labor job please!"+"It is Empty ", "Error");
                return false;
            }
            else if (txt_labor_email.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Email please!", "Error");
                return false;
            }
            else if (com_city.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid City please!", "Error");
                return false;
            }
            else if (txt_salary.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid salary please!", "Error");
                return false;
            }
           
            return true;
        }
        private void but_update_Click(object sender, EventArgs e)
        {
            la.Id = lb_id.Text;
            la.Labor_Name = txt_labor_name.Text;
            la.Labor_Phone = Convert.ToInt32(mas_labor_phone.Text);
            la.Labor_Job = lis_labor_job.Text;
            la.LaborEmail = txt_labor_email.Text;
            la.LaborCity = com_city.Text;
            la.Labor_Salary = txt_salary.Text;

            //call update
            var success = la.Updatelabors(la);
           //Refreash 
            dgv_labors_info.DataSource = labors.Getlabor();
            if (success)
            {
                //clear
                ClearControls();
                MessageBox.Show(@"labor has been Update successfully");
            }
            else
            {
                MessageBox.Show(@"Error occured.Please try again...");
            }
        }


        private void but_delete_Click(object sender, EventArgs e)
        {
            la.Id = lb_id.Text;
            la.Labor_Name = txt_labor_name.Text;
            //call
            var success = la.Deletelabors(la);
            //Referash
            dgv_labors_info.DataSource = labors.Getlabor();
            if (success)
            {
                //clear
                ClearControls();
                MessageBox.Show(@"Labors has been deleted successfully ");

            }
            else {
                MessageBox.Show(@"Error occured. Please try again...");
            }
        }

       

        private void EmployeeJob_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit",MessageBoxButtons.YesNo);
            e.Cancel = (result == DialogResult.No);
               
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, pnl_controls.Text);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dgv_labors_info.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void dgv_labors_info_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            lb_id.Text = dgv_labors_info.Rows[index].Cells[0].Value.ToString();
            txt_labor_name.Text = dgv_labors_info.Rows[index].Cells[1].Value.ToString();
            mas_labor_phone.Text = dgv_labors_info.Rows[index].Cells[2].Value.ToString();
            lis_labor_job.Text = dgv_labors_info.Rows[index].Cells[3].Value.ToString();
            txt_labor_email.Text = dgv_labors_info.Rows[index].Cells[4].Value.ToString();
            com_city.Text = dgv_labors_info.Rows[index].Cells[5].Value.ToString();
            txt_salary.Text = dgv_labors_info.Rows[index].Cells[6].Value.ToString();
        }
        private void dgv_labors_info_RowHeaderMouseClickClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void com_city_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lis_labor_job_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txt_labor_name_TextChanged(object sender, EventArgs e)
        {
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void txt_labor_address_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_labor_email_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_labor_Id_number_TextChanged(object sender, EventArgs e)
        {
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
