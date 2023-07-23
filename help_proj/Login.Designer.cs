namespace WindowsFormsApplication1
{
    partial class Login
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
            this.btn_create_acc = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_User_Name = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Username_txt = new System.Windows.Forms.Label();
            this.Pass_txt = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chk_box = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.but_close = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_create_acc
            // 
            this.btn_create_acc.BackColor = System.Drawing.Color.Orange;
            this.btn_create_acc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.btn_create_acc.Location = new System.Drawing.Point(145, 324);
            this.btn_create_acc.Name = "btn_create_acc";
            this.btn_create_acc.Size = new System.Drawing.Size(178, 54);
            this.btn_create_acc.TabIndex = 0;
            this.btn_create_acc.Text = "Create account";
            this.btn_create_acc.UseVisualStyleBackColor = false;
            this.btn_create_acc.Click += new System.EventHandler(this.btn_create_acc_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Orange;
            this.btn_login.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.btn_login.Location = new System.Drawing.Point(180, 246);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(113, 50);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_User_Name
            // 
            this.txt_User_Name.Location = new System.Drawing.Point(203, 70);
            this.txt_User_Name.Name = "txt_User_Name";
            this.txt_User_Name.Size = new System.Drawing.Size(279, 24);
            this.txt_User_Name.TabIndex = 0;
            this.txt_User_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_User_Name_KeyPress);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(203, 144);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(279, 24);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // Username_txt
            // 
            this.Username_txt.AutoSize = true;
            this.Username_txt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Username_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Username_txt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.Username_txt.Location = new System.Drawing.Point(24, 69);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(98, 23);
            this.Username_txt.TabIndex = 5;
            this.Username_txt.Text = "User name:";
            // 
            // Pass_txt
            // 
            this.Pass_txt.AutoSize = true;
            this.Pass_txt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Pass_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pass_txt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.Pass_txt.Location = new System.Drawing.Point(24, 144);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Size = new System.Drawing.Size(89, 23);
            this.Pass_txt.TabIndex = 6;
            this.Pass_txt.Text = "Password:";
            this.Pass_txt.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel4.Controls.Add(this.chk_box);
            this.panel4.Controls.Add(this.btn_create_acc);
            this.panel4.Controls.Add(this.txt_Password);
            this.panel4.Controls.Add(this.btn_login);
            this.panel4.Controls.Add(this.Pass_txt);
            this.panel4.Controls.Add(this.Username_txt);
            this.panel4.Controls.Add(this.txt_User_Name);
            this.panel4.Location = new System.Drawing.Point(25, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 405);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // chk_box
            // 
            this.chk_box.AutoSize = true;
            this.chk_box.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.chk_box.Location = new System.Drawing.Point(24, 190);
            this.chk_box.Name = "chk_box";
            this.chk_box.Size = new System.Drawing.Size(148, 25);
            this.chk_box.TabIndex = 8;
            this.chk_box.Text = "Show Password";
            this.chk_box.UseVisualStyleBackColor = true;
            this.chk_box.CheckedChanged += new System.EventHandler(this.chl_box_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.IMG_20210610_WA0004;
            this.pictureBox1.Location = new System.Drawing.Point(25, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label3.Location = new System.Drawing.Point(131, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "Help System ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "www.IUTT.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Copyright2021";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // but_close
            // 
            this.but_close.BackColor = System.Drawing.Color.AntiqueWhite;
            this.but_close.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.but_close.ForeColor = System.Drawing.Color.Black;
            this.but_close.Location = new System.Drawing.Point(519, 12);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(36, 31);
            this.but_close.TabIndex = 12;
            this.but_close.Text = "X";
            this.but_close.UseVisualStyleBackColor = false;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(167, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "programming IUTT";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(567, 579);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_closing);
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create_acc;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_User_Name;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label Username_txt;
        private System.Windows.Forms.Label Pass_txt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_box;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Label label9;
    }
}

