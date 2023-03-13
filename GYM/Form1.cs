using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void cikisbuton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giristext_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifretext_TextChanged(object sender, EventArgs e)
        {
            sifretext.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (giristext.Text=="admin" && sifretext.Text=="admin")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız veya şifreniz hatalıdır.");
                giristext.Clear();
                sifretext.Clear();
                giristext.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giristext.Clear();
            sifretext.Clear();
            giristext.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
