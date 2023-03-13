namespace GYMApplication
{
    partial class UyeGoruntuleme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeGoruntuleme));
            this.label1 = new System.Windows.Forms.Label();
            this.memberlist = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resetbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.form2exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memberlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 98);
            this.label1.TabIndex = 13;
            this.label1.Text = "KARABÖCEK SPOR SALONU\r\nÜye Görüntüleme İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memberlist
            // 
            this.memberlist.AllowUserToAddRows = false;
            this.memberlist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            this.memberlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.memberlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberlist.BackgroundColor = System.Drawing.Color.White;
            this.memberlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.memberlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.memberlist.ColumnHeadersHeight = 30;
            this.memberlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memberlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.memberlist.Location = new System.Drawing.Point(94, 164);
            this.memberlist.Name = "memberlist";
            this.memberlist.ReadOnly = true;
            this.memberlist.RowHeadersWidth = 51;
            this.memberlist.RowTemplate.Height = 24;
            this.memberlist.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.memberlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberlist.Size = new System.Drawing.Size(753, 304);
            this.memberlist.TabIndex = 30;
            this.memberlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberlist_CellClick);
            this.memberlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberlist_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 29);
            this.textBox1.TabIndex = 40;
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(564, 116);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(126, 29);
            this.resetbutton.TabIndex = 47;
            this.resetbutton.Text = "SIFIRLA";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 48;
            this.button1.Text = "ARAMA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 41);
            this.button2.TabIndex = 49;
            this.button2.Text = "ANA MENÜ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form2exit
            // 
            this.form2exit.BackColor = System.Drawing.Color.Black;
            this.form2exit.Font = new System.Drawing.Font("Rockwell", 12F);
            this.form2exit.ForeColor = System.Drawing.Color.DarkOrange;
            this.form2exit.Location = new System.Drawing.Point(875, 8);
            this.form2exit.Name = "form2exit";
            this.form2exit.Size = new System.Drawing.Size(50, 50);
            this.form2exit.TabIndex = 52;
            this.form2exit.Text = "X";
            this.form2exit.UseVisualStyleBackColor = false;
            this.form2exit.Click += new System.EventHandler(this.form2exit_Click);
            // 
            // UyeGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 527);
            this.Controls.Add(this.form2exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.memberlist);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UyeGoruntuleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UyeGoruntuleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView memberlist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button form2exit;
    }
}