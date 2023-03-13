using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GYM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();



        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\visualtbl\GYMTBL.mdf;Integrated Security=True;Connect Timeout=30");


        private void anamenubutton_Click(object sender, EventArgs e)
        {
            Form2 log = new Form2();

            log.Show();
            this.Hide();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


            textBox1.Focus();

            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {    

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Eksik bilgi girdiniz.");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string sorgulama = "insert into MemberTbl values('" + textBox1.Text + "','" + textBox2.Text  + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(sorgulama, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla eklendi");

                    sqlcon.Close();
                }
                catch (Exception Ex)
                {
                    
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form3 uyeekleme = new Form3();
        }

        private void form2exit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
