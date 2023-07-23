namespace WindowsFormsApplication1
{
    partial class EmployeeJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeJob));
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_controls = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pan_Control = new System.Windows.Forms.Panel();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_labor_name = new System.Windows.Forms.TextBox();
            this.com_city = new System.Windows.Forms.ComboBox();
            this.mas_labor_phone = new System.Windows.Forms.MaskedTextBox();
            this.txt_labor_email = new System.Windows.Forms.TextBox();
            this.lis_labor_job = new System.Windows.Forms.ListBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lab_city = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgv_labors_info = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_controls.SuspendLayout();
            this.pan_Control.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labors_info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.but_clear);
            this.panel2.Controls.Add(this.but_delete);
            this.panel2.Controls.Add(this.but_update);
            this.panel2.Controls.Add(this.but_add);
            this.panel2.Location = new System.Drawing.Point(844, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 861);
            this.panel2.TabIndex = 19;
            // 
            // but_clear
            // 
            this.but_clear.BackColor = System.Drawing.Color.AntiqueWhite;
            this.but_clear.Font = new System.Drawing.Font("Tahoma", 12F);
            this.but_clear.Location = new System.Drawing.Point(16, 367);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(162, 55);
            this.but_clear.TabIndex = 0;
            this.but_clear.Text = "Clear";
            this.but_clear.UseVisualStyleBackColor = false;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.Color.AntiqueWhite;
            this.but_delete.Font = new System.Drawing.Font("Tahoma", 12F);
            this.but_delete.Location = new System.Drawing.Point(16, 255);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(162, 55);
            this.but_delete.TabIndex = 0;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_update
            // 
            this.but_update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.but_update.Font = new System.Drawing.Font("Tahoma", 12F);
            this.but_update.Location = new System.Drawing.Point(16, 148);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(162, 55);
            this.but_update.TabIndex = 0;
            this.but_update.Text = "Update";
            this.but_update.UseVisualStyleBackColor = false;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.AntiqueWhite;
            this.but_add.Font = new System.Drawing.Font("Tahoma", 12F);
            this.but_add.Location = new System.Drawing.Point(16, 53);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(162, 55);
            this.but_add.TabIndex = 0;
            this.but_add.Text = "Add";
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(224, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 101);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee Job";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 138);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label12.Location = new System.Drawing.Point(22, 107);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Copyright2021";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label10.Location = new System.Drawing.Point(22, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "www.IUTT.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Location = new System.Drawing.Point(11, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "programming IUTT";
            // 
            // pnl_controls
            // 
            this.pnl_controls.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnl_controls.Controls.Add(this.label3);
            this.pnl_controls.Controls.Add(this.pan_Control);
            this.pnl_controls.Controls.Add(this.lb_id);
            this.pnl_controls.Controls.Add(this.lab_city);
            this.pnl_controls.Controls.Add(this.label4);
            this.pnl_controls.Controls.Add(this.label2);
            this.pnl_controls.Controls.Add(this.label6);
            this.pnl_controls.Controls.Add(this.label7);
            this.pnl_controls.Controls.Add(this.menuStrip1);
            this.pnl_controls.Location = new System.Drawing.Point(2, 138);
            this.pnl_controls.Name = "pnl_controls";
            this.pnl_controls.Size = new System.Drawing.Size(839, 541);
            this.pnl_controls.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // pan_Control
            // 
            this.pan_Control.Controls.Add(this.txt_salary);
            this.pan_Control.Controls.Add(this.txt_labor_name);
            this.pan_Control.Controls.Add(this.com_city);
            this.pan_Control.Controls.Add(this.mas_labor_phone);
            this.pan_Control.Controls.Add(this.txt_labor_email);
            this.pan_Control.Controls.Add(this.lis_labor_job);
            this.pan_Control.Location = new System.Drawing.Point(214, 37);
            this.pan_Control.Name = "pan_Control";
            this.pan_Control.Size = new System.Drawing.Size(565, 501);
            this.pan_Control.TabIndex = 21;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(103, 432);
            this.txt_salary.Multiline = true;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(385, 40);
            this.txt_salary.TabIndex = 1;
            // 
            // txt_labor_name
            // 
            this.txt_labor_name.Location = new System.Drawing.Point(103, 17);
            this.txt_labor_name.Multiline = true;
            this.txt_labor_name.Name = "txt_labor_name";
            this.txt_labor_name.Size = new System.Drawing.Size(385, 40);
            this.txt_labor_name.TabIndex = 1;
            this.txt_labor_name.TextChanged += new System.EventHandler(this.txt_labor_name_TextChanged);
            // 
            // com_city
            // 
            this.com_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_city.FormattingEnabled = true;
            this.com_city.Location = new System.Drawing.Point(103, 362);
            this.com_city.Name = "com_city";
            this.com_city.Size = new System.Drawing.Size(385, 24);
            this.com_city.TabIndex = 5;
            this.com_city.SelectedIndexChanged += new System.EventHandler(this.com_city_SelectedIndexChanged);
            // 
            // mas_labor_phone
            // 
            this.mas_labor_phone.Location = new System.Drawing.Point(103, 94);
            this.mas_labor_phone.Mask = "(999)000-000";
            this.mas_labor_phone.Name = "mas_labor_phone";
            this.mas_labor_phone.Size = new System.Drawing.Size(385, 24);
            this.mas_labor_phone.TabIndex = 2;
            this.mas_labor_phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_labor_email
            // 
            this.txt_labor_email.Location = new System.Drawing.Point(103, 291);
            this.txt_labor_email.Multiline = true;
            this.txt_labor_email.Name = "txt_labor_email";
            this.txt_labor_email.Size = new System.Drawing.Size(385, 40);
            this.txt_labor_email.TabIndex = 4;
            this.txt_labor_email.TextChanged += new System.EventHandler(this.txt_labor_email_TextChanged);
            // 
            // lis_labor_job
            // 
            this.lis_labor_job.FormattingEnabled = true;
            this.lis_labor_job.ItemHeight = 16;
            this.lis_labor_job.Location = new System.Drawing.Point(103, 163);
            this.lis_labor_job.Name = "lis_labor_job";
            this.lis_labor_job.Size = new System.Drawing.Size(385, 84);
            this.lis_labor_job.TabIndex = 3;
            this.lis_labor_job.SelectedIndexChanged += new System.EventHandler(this.lis_labor_job_SelectedIndexChanged);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(89, 37);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(0, 17);
            this.lb_id.TabIndex = 5;
            this.lb_id.Visible = false;
            // 
            // lab_city
            // 
            this.lab_city.AutoSize = true;
            this.lab_city.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_city.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lab_city.Location = new System.Drawing.Point(30, 399);
            this.lab_city.Name = "lab_city";
            this.lab_city.Size = new System.Drawing.Size(51, 26);
            this.lab_city.TabIndex = 1;
            this.lab_city.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "labor email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "labor job";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "labor name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(30, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "labor Phone";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileToolStripMenuItem.Text = "&File";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.openFileToolStripMenuItem.Text = "&Open";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(164, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // dgv_labors_info
            // 
            this.dgv_labors_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_labors_info.Location = new System.Drawing.Point(2, 685);
            this.dgv_labors_info.Name = "dgv_labors_info";
            this.dgv_labors_info.RowTemplate.Height = 26;
            this.dgv_labors_info.Size = new System.Drawing.Size(839, 314);
            this.dgv_labors_info.TabIndex = 25;
            this.dgv_labors_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_labors_info_RowHeaderMouseClickClick);
            this.dgv_labors_info.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_labors_info_RowHeaderMouseClick);
            // 
            // EmployeeJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1034, 1001);
            this.Controls.Add(this.dgv_labors_info);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_controls);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployJob";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeJob_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeJob_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_controls.ResumeLayout(false);
            this.pnl_controls.PerformLayout();
            this.pan_Control.ResumeLayout(false);
            this.pan_Control.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labors_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Panel pnl_controls;
        private System.Windows.Forms.TextBox txt_labor_name;
        private System.Windows.Forms.Label lab_city;
        private System.Windows.Forms.TextBox txt_labor_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_labors_info;
        private System.Windows.Forms.MaskedTextBox mas_labor_phone;
        private System.Windows.Forms.ListBox lis_labor_job;
        private System.Windows.Forms.ComboBox com_city;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pan_Control;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}