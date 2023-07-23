namespace WindowsFormsApplication1
{
    partial class OrderUsers
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lab_id = new System.Windows.Forms.Label();
            this.txb_ = new System.Windows.Forms.Label();
            this.txb_note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 151);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.IMG_20210610_WA0004;
            this.pictureBox1.Location = new System.Drawing.Point(39, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(214, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 101);
            this.label1.TabIndex = 20;
            this.label1.Text = "Services";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Location = new System.Drawing.Point(529, 465);
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
            this.label10.Location = new System.Drawing.Point(316, 465);
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
            this.label9.Location = new System.Drawing.Point(84, 465);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "programming IUTT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.txb_Address);
            this.panel1.Controls.Add(this.btn_send);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.lab_id);
            this.panel1.Controls.Add(this.txb_);
            this.panel1.Controls.Add(this.txb_note);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 293);
            this.panel1.TabIndex = 11;
            // 
            // txb_Address
            // 
            this.txb_Address.Location = new System.Drawing.Point(183, 18);
            this.txb_Address.Multiline = true;
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(389, 119);
            this.txb_Address.TabIndex = 8;
            this.txb_Address.TextChanged += new System.EventHandler(this.txb_Address_TextChanged);
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Orange;
            this.btn_send.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.btn_send.Location = new System.Drawing.Point(611, 36);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(208, 64);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Orange;
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.btn_back.Location = new System.Drawing.Point(611, 175);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(208, 64);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lab_id
            // 
            this.lab_id.AutoSize = true;
            this.lab_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.lab_id.Location = new System.Drawing.Point(49, 26);
            this.lab_id.Name = "lab_id";
            this.lab_id.Size = new System.Drawing.Size(2, 26);
            this.lab_id.TabIndex = 9;
            this.lab_id.Visible = false;
            // 
            // txb_
            // 
            this.txb_.AutoSize = true;
            this.txb_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txb_.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.txb_.Location = new System.Drawing.Point(75, 56);
            this.txb_.Name = "txb_";
            this.txb_.Size = new System.Drawing.Size(87, 26);
            this.txb_.TabIndex = 7;
            this.txb_.Text = "Location";
            // 
            // txb_note
            // 
            this.txb_note.Location = new System.Drawing.Point(183, 164);
            this.txb_note.Multiline = true;
            this.txb_note.Name = "txb_note";
            this.txb_note.Size = new System.Drawing.Size(389, 116);
            this.txb_note.TabIndex = 4;
            this.txb_note.TextChanged += new System.EventHandler(this.txb_note_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(75, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note";
            // 
            // OrderUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(848, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "OrderUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requiest for services";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_order_FormClosing);
            this.Load += new System.EventHandler(this.frm_order_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label txb_;
        private System.Windows.Forms.TextBox txb_note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_id;
    }
}