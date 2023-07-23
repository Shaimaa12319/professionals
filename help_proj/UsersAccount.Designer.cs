namespace WindowsFormsApplication1
{
    partial class Users_Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txb_RePassowrd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_User_Name = new System.Windows.Forms.TextBox();
            this.btn_Sign_up = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.la_id = new System.Windows.Forms.Label();
            this.txt_ph = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.but_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_RePassowrd
            // 
            this.errorProvider1.SetError(this.txb_RePassowrd, "Re-enter Password is required!");
            this.txb_RePassowrd.Location = new System.Drawing.Point(377, 144);
            this.txb_RePassowrd.Multiline = true;
            this.txb_RePassowrd.Name = "txb_RePassowrd";
            this.txb_RePassowrd.Size = new System.Drawing.Size(367, 38);
            this.txb_RePassowrd.TabIndex = 3;
            this.txb_RePassowrd.Validating += new System.ComponentModel.CancelEventHandler(this.txb_RePassowrd_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(126, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(126, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(80, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re-enter Password:";
            // 
            // txt_Address
            // 
            this.errorProvider1.SetError(this.txt_Address, "Enter your Address.please,to help our labors to know were are you");
            this.txt_Address.Location = new System.Drawing.Point(377, 317);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(367, 38);
            this.txt_Address.TabIndex = 6;
            this.txt_Address.TextChanged += new System.EventHandler(this.txt_Address_TextChanged);
            this.txt_Address.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // txt_Email
            // 
            this.errorProvider1.SetError(this.txt_Email, "Enter your Email.please,to helpe us to interaction with your order");
            this.txt_Email.Location = new System.Drawing.Point(377, 200);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(367, 38);
            this.txt_Email.TabIndex = 4;
            this.txt_Email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Email_Validating);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.email.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.email.Location = new System.Drawing.Point(126, 200);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(84, 29);
            this.email.TabIndex = 9;
            this.email.Text = "Email:";
            // 
            // txt_password
            // 
            this.errorProvider1.SetError(this.txt_password, "Passowerd is equired!");
            this.txt_password.Location = new System.Drawing.Point(377, 80);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(367, 38);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            this.txt_password.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(126, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Passowrd:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(126, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Phone Number";
            // 
            // txt_User_Name
            // 
            this.errorProvider1.SetError(this.txt_User_Name, "User name is required!");
            this.txt_User_Name.Location = new System.Drawing.Point(377, 22);
            this.txt_User_Name.Multiline = true;
            this.txt_User_Name.Name = "txt_User_Name";
            this.txt_User_Name.Size = new System.Drawing.Size(367, 38);
            this.txt_User_Name.TabIndex = 1;
            this.txt_User_Name.TextChanged += new System.EventHandler(this.txt_user_namee_TextChanged);
            this.txt_User_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_User_Name_KeyPress);
            this.txt_User_Name.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // btn_Sign_up
            // 
            this.btn_Sign_up.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Sign_up.Location = new System.Drawing.Point(53, 80);
            this.btn_Sign_up.Name = "btn_Sign_up";
            this.btn_Sign_up.Size = new System.Drawing.Size(136, 69);
            this.btn_Sign_up.TabIndex = 16;
            this.btn_Sign_up.Text = "Sign up";
            this.btn_Sign_up.UseVisualStyleBackColor = false;
            this.btn_Sign_up.Click += new System.EventHandler(this.btn_Sign_up_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.la_id);
            this.panel1.Controls.Add(this.txt_User_Name);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_ph);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Controls.Add(this.txb_RePassowrd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 419);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // la_id
            // 
            this.la_id.AutoSize = true;
            this.la_id.Location = new System.Drawing.Point(47, 10);
            this.la_id.Name = "la_id";
            this.la_id.Size = new System.Drawing.Size(52, 17);
            this.la_id.TabIndex = 18;
            this.la_id.Text = "           ";
            // 
            // txt_ph
            // 
            this.errorProvider1.SetError(this.txt_ph, "Enter your Phone number.");
            this.txt_ph.Location = new System.Drawing.Point(377, 256);
            this.txt_ph.Multiline = true;
            this.txt_ph.Name = "txt_ph";
            this.txt_ph.Size = new System.Drawing.Size(367, 38);
            this.txt_ph.TabIndex = 5;
            this.txt_ph.TextChanged += new System.EventHandler(this.txt_ph_TextChanged);
            this.txt_ph.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ph_KeyPress);
            this.txt_ph.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ph_Validating);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 149);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(187, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(605, 101);
            this.label5.TabIndex = 3;
            this.label5.Text = "Create Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.IMG_20210610_WA0004;
            this.pictureBox1.Location = new System.Drawing.Point(32, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Location = new System.Drawing.Point(104, 571);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "programming IUTT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Location = new System.Drawing.Point(643, 571);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Copyright2021";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label10.Location = new System.Drawing.Point(374, 571);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "www.IUTT.com";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.but_back);
            this.panel3.Controls.Add(this.btn_Sign_up);
            this.panel3.Location = new System.Drawing.Point(798, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 419);
            this.panel3.TabIndex = 19;
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.AntiqueWhite;
            this.but_back.Location = new System.Drawing.Point(53, 183);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(136, 69);
            this.but_back.TabIndex = 16;
            this.but_back.Text = "Back";
            this.but_back.UseVisualStyleBackColor = false;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // Users_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1037, 597);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.Name = "Users_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_Account_FormClosing);
            this.Load += new System.EventHandler(this.frm_create_acc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_RePassowrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_User_Name;
        private System.Windows.Forms.Button btn_Sign_up;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label la_id;
        private System.Windows.Forms.TextBox txt_ph;
        private System.Windows.Forms.Button but_back;
    }
}