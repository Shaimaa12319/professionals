using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class show_ : Form
    {
        public show_()
        {
            InitializeComponent();
         
        }

        private void but_Plumbing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You select Plumbing Service.");
            MessageBox.Show(" Now Beacuse we want know your location to accsess to you fastlly, We will move you to onther form to insert your location and your note about your problem you have");
            OrderUsers o = new OrderUsers();
            o.Show();
            this.Hide();
        }

        private void but_carpentry_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You select Carpentry Service.");
            MessageBox.Show(" Now Beacuse we want know your location to accsess to you fastlly, We will move you to onther form to insert your location and your note about your problem you have");
            OrderUsers o = new OrderUsers();
            o.Show();
            this.Hide();

        }

        private void but_techer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You select Techer Service.");
            MessageBox.Show(" Now Beacuse we want know your location to accsess to you fastlly, We will move you to onther form to insert your location and your note about your problem you have");
            OrderUsers o = new OrderUsers();
            o.Show();
            this.Hide();
        }

        private void but_blacksmith_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You select Blacksmith Service.");
            MessageBox.Show(" Now Beacuse we want know your location to accsess to you fastlly, We will move you to onther form to insert your location and your note about your problem you have");
            OrderUsers o = new OrderUsers();
            o.Show();
            this.Hide();
        }

        private void but_electricain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You select Electricain Service.");
            MessageBox.Show(" Now Beacuse we want know your location to accsess to you fastlly, We will move you to onther form to insert your location andyour note about your problem you have");
            OrderUsers o = new OrderUsers();
            o.Show();
            this.Hide();
        }

        private void but_Macanich_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You select Macanich Service.");
            MessageBox.Show(" Now Beacuse we want know your location to accsess to you fastlly, We will move you to onther form to insert your location and your note about your problem you have");
            OrderUsers o = new OrderUsers();
            o.Show();
            this.Hide();
        }
    
        private void show__Load(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }      
    }
}
