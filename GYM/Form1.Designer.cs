namespace GYM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cikisbuton = new System.Windows.Forms.Button();
            this.giristext = new System.Windows.Forms.TextBox();
            this.sifretext = new System.Windows.Forms.TextBox();
            this.girisbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "KARABÖCEK SPOR SALONU";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(701, 65);
            this.label2.TabIndex = 2;
            // 
            // cikisbuton
            // 
            this.cikisbuton.BackColor = System.Drawing.Color.Black;
            this.cikisbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cikisbuton.ForeColor = System.Drawing.Color.DarkOrange;
            this.cikisbuton.Location = new System.Drawing.Point(637, 8);
            this.cikisbuton.Name = "cikisbuton";
            this.cikisbuton.Size = new System.Drawing.Size(50, 50);
            this.cikisbuton.TabIndex = 3;
            this.cikisbuton.Text = "X";
            this.cikisbuton.UseVisualStyleBackColor = false;
            this.cikisbuton.Click += new System.EventHandler(this.cikisbuton_Click);
            // 
            // giristext
            // 
            this.giristext.Font = new System.Drawing.Font("Rockwell", 18F);
            this.giristext.Location = new System.Drawing.Point(92, 118);
            this.giristext.Multiline = true;
            this.giristext.Name = "giristext";
            this.giristext.Size = new System.Drawing.Size(205, 50);
            this.giristext.TabIndex = 4;
            this.giristext.TextChanged += new System.EventHandler(this.giristext_TextChanged);
            // 
            // sifretext
            // 
            this.sifretext.Font = new System.Drawing.Font("Rockwell", 18F);
            this.sifretext.Location = new System.Drawing.Point(92, 194);
            this.sifretext.Multiline = true;
            this.sifretext.Name = "sifretext";
            this.sifretext.PasswordChar = '*';
            this.sifretext.Size = new System.Drawing.Size(205, 50);
            this.sifretext.TabIndex = 5;
            this.sifretext.TextChanged += new System.EventHandler(this.sifretext_TextChanged);
            // 
            // girisbutton
            // 
            this.girisbutton.BackColor = System.Drawing.Color.Teal;
            this.girisbutton.Font = new System.Drawing.Font("Rockwell", 18F);
            this.girisbutton.ForeColor = System.Drawing.Color.White;
            this.girisbutton.Location = new System.Drawing.Point(322, 118);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.Size = new System.Drawing.Size(141, 50);
            this.girisbutton.TabIndex = 6;
            this.girisbutton.Text = "GİRİS";
            this.girisbutton.UseVisualStyleBackColor = false;
            this.girisbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.Teal;
            this.resetbutton.Font = new System.Drawing.Font("Rockwell", 18F);
            this.resetbutton.ForeColor = System.Drawing.Color.White;
            this.resetbutton.Location = new System.Drawing.Point(322, 194);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(141, 50);
            this.resetbutton.TabIndex = 7;
            this.resetbutton.Text = "SIFIRLA";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 286);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.girisbutton);
            this.Controls.Add(this.sifretext);
            this.Controls.Add(this.giristext);
            this.Controls.Add(this.cikisbuton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cikisbuton;
        private System.Windows.Forms.TextBox giristext;
        private System.Windows.Forms.TextBox sifretext;
        private System.Windows.Forms.Button girisbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

