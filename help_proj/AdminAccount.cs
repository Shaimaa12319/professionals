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
    public partial class AdminAccount : Form
    {
        Adminn admin = new Adminn();
        public AdminAccount()
        {
            InitializeComponent();
            dgv_employee_info.DataSource = Adminn.GetAdminnn();
        }

        private void but_clear_Clear(object sender, EventArgs e)
        {
            ClearControls();

        }
        private void ClearControls()
        {
            foreach (Control control in pa_conn.Controls)
            {
                control.Text = "";
            }
        }
        private void AdminAccount_Load(object sender, EventArgs e)
        {
            com_city.Text = "Select your city:";
            com_city.Items.AddRange(new string[] { "Sana'a", "Aden", "Ibb", "Taiz", "Hadramoot", "Hodedah", "Albedaa", "Rdaa" });
            li_job.ValueMember = "value";
            li_job.DisplayMember = "Key";
            li_job.DataSource = new KeyValuePair<string, int>[]
            { 
                 new KeyValuePair<string,int  >("Programmer",1),
                 new KeyValuePair<string,int  >("Accountant",2),
                 new KeyValuePair<string,int  >("Registered",3),
                 new KeyValuePair<string,int  >("Recipient of order",4),
                 
            };
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                    admin.EmployeeName = txt_employee_name.Text;
                    admin.EmployeePhone = mas_phone_num.Text;
                    admin.EmployeeAddress = txt_employee_address.Text;
                    admin.EmployeeCity = com_city.Text;
                    admin.EmployeeJob = li_job.Text;
                    admin.EmployeeSalary = txt_salary.Text;
                    //call
                    bool success = admin.InsertAdminn(admin);
                    //Refresh
                    dgv_employee_info.DataSource = Adminn.GetAdminnn();
                    if (success)
                    {
                        ClearControls();
                        MessageBox.Show(@"Admin has been added successfully");
                    }
                    else
                        MessageBox.Show(@"Error occured. Please try again ...");
                }

               
            
        }
        private bool isValid()
        {
            if (txt_employee_name.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Employee name please!", "Error");
                return false;
            }
            else if (mas_phone_num.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Phone please!", "Error");
                return false;
            }
            else if (txt_employee_address.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Address Employee please!" + "It is Empty ", "Error");
                return false;
            }
            else if (com_city.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid City please!", "Error");
                return false;
            }
            else if (li_job.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid Job  please!", "Error");
                return false;
            }
            else if (txt_salary.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error valid salary  please!", "Error");
                return false;
            }

            return true;
        }

        private void bbt_update_Click(object sender, EventArgs e)
        {
            admin.Id = li_id.Text;
            admin.EmployeeName = txt_employee_name.Text;
            admin.EmployeePhone = mas_phone_num.Text;
            admin.EmployeeAddress = txt_employee_address.Text;
            admin.EmployeeCity = com_city.Text;
            admin.EmployeeJob = li_job.Text;
            admin.EmployeeSalary = txt_salary.Text;
            //call
            var success = admin.UpdateAdminn(admin);
            //Refreash
            dgv_employee_info.DataSource = Adminn.GetAdminnn();
            if (success)
            {
                ClearControls();
                MessageBox.Show(@"Admin has been Update successfully ");
            }
            else
                MessageBox.Show(@"Error occured. Please try again...");
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            admin.Id = li_id.Text;
            admin.EmployeeName = txt_employee_name.Text;


            //call
            var success = admin.DeleteAdminn(admin);
            //Refreash
            dgv_employee_info.DataSource = Adminn.GetAdminnn();
            if (success)
            {
                ClearControls();
                MessageBox.Show(@"Admin has been Deleted successfully ");
            }
            else
                MessageBox.Show(@"Error occured. Please try again...");
        }

        private void exitFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, pan_ControlAll.Text);
            }
        }

        private void AdminAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            e.Cancel = (result == DialogResult.No);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dgv_employee_info.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void dgv_employee_info_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            li_id.Text = dgv_employee_info.Rows[index].Cells[0].Value.ToString();
            txt_employee_name.Text = dgv_employee_info.Rows[index].Cells[1].Value.ToString();
            mas_phone_num.Text = dgv_employee_info.Rows[index].Cells[2].Value.ToString();
            txt_employee_address.Text = dgv_employee_info.Rows[index].Cells[3].Value.ToString();
            com_city.Text = dgv_employee_info.Rows[index].Cells[4].Value.ToString();
            li_job.Text = dgv_employee_info.Rows[index].Cells[5].Value.ToString();
            txt_salary.Text = dgv_employee_info.Rows[index].Cells[6].Value.ToString();

        }
        private void dgv_employee_info_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void com_city_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void mas_phone_num_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void li_job_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        }
    }

