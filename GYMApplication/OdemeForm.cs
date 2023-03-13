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

namespace GYMApplication
{
    public partial class OdemeForm : Form
    {
        public OdemeForm()
        {
            InitializeComponent();
        }


        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\visualtbl\GYMTBL.mdf;Integrated Security=True;Connect Timeout=30");

        private void FillName()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Select MName from MemberTbl", sqlcon);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MName", typeof(string));
            dt.Load(rdr);
            comboBox2.ValueMember = "MName";
            comboBox2.DataSource = dt;

            sqlcon.Close();
        }

        private void populasyon()
        {
            sqlcon.Open();
            string sorgulama = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(sorgulama, sqlcon);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlcon.Close();

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            
            textBox2.Text = "";
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form2 anamenu = new Form2();
            anamenu.Show();
            this.Hide();
        }
        int key = 1;
        private void pay_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Eksik bilgi girdiniz.");
            }
            else
            {
                string payperiode = dateTimePicker1.Value.ToString() + dateTimePicker1.Value.Year.ToString();
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PaymentTbl where PMember='"+comboBox2.SelectedValue.ToString()+"' and PMonth='"+payperiode+"'",sqlcon);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Bu ay için ödendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "insert into PaymentTbl values ('" + payperiode + "','" + comboBox2.SelectedValue.ToString()+"',"+textBox2.Text+")";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ödeme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sqlcon.Close();
            }

            populasyon();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            FillName();
            populasyon();
        }
    }
}
