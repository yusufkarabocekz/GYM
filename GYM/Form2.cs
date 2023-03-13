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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeGoruntuleme update = new UyeGoruntuleme();
            update.Show();
            this.Hide();

        }

        private void form2exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guncellesilbutton_Click(object sender, EventArgs e)
        {
            GuncelleSil silme = new GuncelleSil();
            silme.Show();
            this.Hide();
        }

        private void odemebutton_Click(object sender, EventArgs e)
        {
            OdemeForm odeme = new OdemeForm();
            odeme.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
