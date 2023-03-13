namespace GYM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.üyebutton = new System.Windows.Forms.Button();
            this.guncellesilbutton = new System.Windows.Forms.Button();
            this.odemebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salon1picturebox = new System.Windows.Forms.PictureBox();
            this.form2exit = new System.Windows.Forms.Button();
            this.uyegoruntulebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salon1picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(938, 71);
            this.label1.TabIndex = 0;
            // 
            // üyebutton
            // 
            this.üyebutton.Font = new System.Drawing.Font("Rockwell", 12F);
            this.üyebutton.Location = new System.Drawing.Point(142, 12);
            this.üyebutton.Name = "üyebutton";
            this.üyebutton.Size = new System.Drawing.Size(143, 43);
            this.üyebutton.TabIndex = 1;
            this.üyebutton.Text = "ÜYE EKLE";
            this.üyebutton.UseVisualStyleBackColor = true;
            this.üyebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // guncellesilbutton
            // 
            this.guncellesilbutton.Font = new System.Drawing.Font("Rockwell", 12F);
            this.guncellesilbutton.Location = new System.Drawing.Point(548, 12);
            this.guncellesilbutton.Name = "guncellesilbutton";
            this.guncellesilbutton.Size = new System.Drawing.Size(178, 43);
            this.guncellesilbutton.TabIndex = 3;
            this.guncellesilbutton.Text = "GÜNCELLE/SİL";
            this.guncellesilbutton.UseVisualStyleBackColor = true;
            this.guncellesilbutton.Click += new System.EventHandler(this.guncellesilbutton_Click);
            // 
            // odemebutton
            // 
            this.odemebutton.Font = new System.Drawing.Font("Rockwell", 12F);
            this.odemebutton.Location = new System.Drawing.Point(738, 12);
            this.odemebutton.Name = "odemebutton";
            this.odemebutton.Size = new System.Drawing.Size(119, 43);
            this.odemebutton.TabIndex = 4;
            this.odemebutton.Text = "ÖDEME";
            this.odemebutton.UseVisualStyleBackColor = true;
            this.odemebutton.Click += new System.EventHandler(this.odemebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // salon1picturebox
            // 
            this.salon1picturebox.Image = ((System.Drawing.Image)(resources.GetObject("salon1picturebox.Image")));
            this.salon1picturebox.Location = new System.Drawing.Point(91, 84);
            this.salon1picturebox.Name = "salon1picturebox";
            this.salon1picturebox.Size = new System.Drawing.Size(752, 414);
            this.salon1picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salon1picturebox.TabIndex = 8;
            this.salon1picturebox.TabStop = false;
            // 
            // form2exit
            // 
            this.form2exit.BackColor = System.Drawing.Color.Black;
            this.form2exit.Font = new System.Drawing.Font("Rockwell", 12F);
            this.form2exit.ForeColor = System.Drawing.Color.DarkOrange;
            this.form2exit.Location = new System.Drawing.Point(875, 8);
            this.form2exit.Name = "form2exit";
            this.form2exit.Size = new System.Drawing.Size(50, 50);
            this.form2exit.TabIndex = 9;
            this.form2exit.Text = "X";
            this.form2exit.UseVisualStyleBackColor = false;
            this.form2exit.Click += new System.EventHandler(this.form2exit_Click);
            // 
            // uyegoruntulebutton
            // 
            this.uyegoruntulebutton.Font = new System.Drawing.Font("Rockwell", 12F);
            this.uyegoruntulebutton.Location = new System.Drawing.Point(291, 12);
            this.uyegoruntulebutton.Name = "uyegoruntulebutton";
            this.uyegoruntulebutton.Size = new System.Drawing.Size(244, 43);
            this.uyegoruntulebutton.TabIndex = 2;
            this.uyegoruntulebutton.Text = "ÜYE GÖRÜNTÜLEME";
            this.uyegoruntulebutton.UseVisualStyleBackColor = true;
            this.uyegoruntulebutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 527);
            this.Controls.Add(this.form2exit);
            this.Controls.Add(this.salon1picturebox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.odemebutton);
            this.Controls.Add(this.guncellesilbutton);
            this.Controls.Add(this.uyegoruntulebutton);
            this.Controls.Add(this.üyebutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salon1picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button üyebutton;
        private System.Windows.Forms.Button guncellesilbutton;
        private System.Windows.Forms.Button odemebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox salon1picturebox;
        private System.Windows.Forms.Button form2exit;
        private System.Windows.Forms.Button uyegoruntulebutton;
    }
}