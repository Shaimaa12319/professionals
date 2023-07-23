namespace WindowsFormsApplication1
{
    partial class DetailsOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsOrder));
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pa_controls = new System.Windows.Forms.Panel();
            this.pa_1 = new System.Windows.Forms.Panel();
            this.dtp_order_date = new System.Windows.Forms.DateTimePicker();
            this.mas_ph = new System.Windows.Forms.MaskedTextBox();
            this.txt_order_note = new System.Windows.Forms.TextBox();
            this.txt_name_coustomer = new System.Windows.Forms.TextBox();
            this.txt_labor_name = new System.Windows.Forms.ComboBox();
            this.txt_order_type = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lab_id = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.dgv_user_info = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pa_controls.SuspendLayout();
            this.pa_1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_info)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, -224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 24);
            this.textBox4.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(154, -217);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 24);
            this.textBox7.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 135);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(242, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 101);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Location = new System.Drawing.Point(17, 104);
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
            this.label10.Location = new System.Drawing.Point(17, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "www.IUTT.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "programming IUTT";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_update.Location = new System.Drawing.Point(30, 147);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(137, 60);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Add.Location = new System.Drawing.Point(30, 36);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(137, 60);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pa_controls
            // 
            this.pa_controls.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pa_controls.Controls.Add(this.pa_1);
            this.pa_controls.Controls.Add(this.label8);
            this.pa_controls.Controls.Add(this.label12);
            this.pa_controls.Controls.Add(this.label13);
            this.pa_controls.Controls.Add(this.lab_id);
            this.pa_controls.Controls.Add(this.label14);
            this.pa_controls.Controls.Add(this.label15);
            this.pa_controls.Controls.Add(this.label17);
            this.pa_controls.Controls.Add(this.menuStrip1);
            this.pa_controls.Location = new System.Drawing.Point(1, 135);
            this.pa_controls.Name = "pa_controls";
            this.pa_controls.Size = new System.Drawing.Size(848, 527);
            this.pa_controls.TabIndex = 23;
            this.pa_controls.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pa_1
            // 
            this.pa_1.Controls.Add(this.dtp_order_date);
            this.pa_1.Controls.Add(this.mas_ph);
            this.pa_1.Controls.Add(this.txt_order_note);
            this.pa_1.Controls.Add(this.txt_name_coustomer);
            this.pa_1.Controls.Add(this.txt_labor_name);
            this.pa_1.Controls.Add(this.txt_order_type);
            this.pa_1.Location = new System.Drawing.Point(226, 32);
            this.pa_1.Name = "pa_1";
            this.pa_1.Size = new System.Drawing.Size(559, 495);
            this.pa_1.TabIndex = 7;
            // 
            // dtp_order_date
            // 
            this.dtp_order_date.CustomFormat = "dd/MMMM/yyyy";
            this.dtp_order_date.Location = new System.Drawing.Point(85, 225);
            this.dtp_order_date.Name = "dtp_order_date";
            this.dtp_order_date.Size = new System.Drawing.Size(200, 24);
            this.dtp_order_date.TabIndex = 7;
            // 
            // mas_ph
            // 
            this.mas_ph.Location = new System.Drawing.Point(85, 151);
            this.mas_ph.Mask = "(999)000-000";
            this.mas_ph.Name = "mas_ph";
            this.mas_ph.Size = new System.Drawing.Size(410, 24);
            this.mas_ph.TabIndex = 3;
            this.mas_ph.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_order_note
            // 
            this.txt_order_note.Location = new System.Drawing.Point(85, 378);
            this.txt_order_note.Multiline = true;
            this.txt_order_note.Name = "txt_order_note";
            this.txt_order_note.Size = new System.Drawing.Size(410, 117);
            this.txt_order_note.TabIndex = 6;
            this.txt_order_note.TextChanged += new System.EventHandler(this.txt_order_note_TextChanged);
            // 
            // txt_name_coustomer
            // 
            this.txt_name_coustomer.Location = new System.Drawing.Point(85, 309);
            this.txt_name_coustomer.Multiline = true;
            this.txt_name_coustomer.Name = "txt_name_coustomer";
            this.txt_name_coustomer.Size = new System.Drawing.Size(410, 46);
            this.txt_name_coustomer.TabIndex = 5;
            // 
            // txt_labor_name
            // 
            this.txt_labor_name.FormattingEnabled = true;
            this.txt_labor_name.Location = new System.Drawing.Point(85, 4);
            this.txt_labor_name.Name = "txt_labor_name";
            this.txt_labor_name.Size = new System.Drawing.Size(410, 24);
            this.txt_labor_name.TabIndex = 1;
            this.txt_labor_name.SelectedIndexChanged += new System.EventHandler(this.txt_labor_name_SelectedIndexChanged);
            // 
            // txt_order_type
            // 
            this.txt_order_type.Location = new System.Drawing.Point(85, 65);
            this.txt_order_type.Multiline = true;
            this.txt_order_type.Name = "txt_order_type";
            this.txt_order_type.Size = new System.Drawing.Size(410, 46);
            this.txt_order_type.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Orange;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(42, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Labor Name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Orange;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(20, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Customer Num:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Orange;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(42, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "Order Date:";
            // 
            // lab_id
            // 
            this.lab_id.AutoSize = true;
            this.lab_id.Location = new System.Drawing.Point(16, 43);
            this.lab_id.Name = "lab_id";
            this.lab_id.Size = new System.Drawing.Size(20, 17);
            this.lab_id.TabIndex = 6;
            this.lab_id.Text = "   ";
            this.lab_id.Visible = false;
            this.lab_id.Click += new System.EventHandler(this.label2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Orange;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(42, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 26);
            this.label14.TabIndex = 0;
            this.label14.Text = "Order Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Orange;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(42, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "Order Note:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Orange;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(9, 341);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 26);
            this.label17.TabIndex = 0;
            this.label17.Text = "Coustomer Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.toolStripSeparator,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openFileToolStripMenuItem.Text = "&Open";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(111, 6);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveFileToolStripMenuItem.Image")));
            this.saveFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.saveFileToolStripMenuItem.Text = "&Save";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.but_clear);
            this.panel1.Controls.Add(this.but_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Location = new System.Drawing.Point(848, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 798);
            this.panel1.TabIndex = 5;
            // 
            // but_clear
            // 
            this.but_clear.BackColor = System.Drawing.Color.AntiqueWhite;
            this.but_clear.Font = new System.Drawing.Font("Tahoma", 12F);
            this.but_clear.Location = new System.Drawing.Point(30, 341);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(137, 60);
            this.but_clear.TabIndex = 6;
            this.but_clear.Text = "Clear";
            this.but_clear.UseVisualStyleBackColor = false;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.Color.AntiqueWhite;
            this.but_delete.Font = new System.Drawing.Font("Tahoma", 12F);
            this.but_delete.Location = new System.Drawing.Point(30, 239);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(137, 60);
            this.but_delete.TabIndex = 6;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // dgv_user_info
            // 
            this.dgv_user_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_info.Location = new System.Drawing.Point(1, 668);
            this.dgv_user_info.Name = "dgv_user_info";
            this.dgv_user_info.RowTemplate.Height = 26;
            this.dgv_user_info.Size = new System.Drawing.Size(841, 265);
            this.dgv_user_info.TabIndex = 6;
            this.dgv_user_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_info_RowHeaderMouseClick);
            this.dgv_user_info.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_user_info_RowHeaderMouseClick);
            // 
            // DetailsOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1046, 932);
            this.Controls.Add(this.dgv_user_info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pa_controls);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DetailsOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderEx";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailsOrder_FormClosing);
            this.Load += new System.EventHandler(this.DetailsOrder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pa_controls.ResumeLayout(false);
            this.pa_controls.PerformLayout();
            this.pa_1.ResumeLayout(false);
            this.pa_1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pa_controls;
        private System.Windows.Forms.ComboBox txt_labor_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_order_type;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_name_coustomer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_order_note;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_user_info;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Label lab_id;
        private System.Windows.Forms.Panel pa_1;
        private System.Windows.Forms.MaskedTextBox mas_ph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DateTimePicker dtp_order_date;
    }
}