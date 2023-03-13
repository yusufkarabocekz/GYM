using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class UyeGoruntuleme : Form
    {
        public UyeGoruntuleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 anamenu = new Form2();
            anamenu.Show();
            this.Hide();
            
        }

        private void form2exit_Click(object sender, EventArgs e)
        {
            Form2 anamenu = new Form2();
            anamenu.Show();
            this.Hide();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\visualtbl\GYMTBL.mdf;Integrated Security=True;Connect Timeout=30");

        private void populasyon()
        {
            sqlcon.Open();
            string sorgulama = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(sorgulama, sqlcon);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            memberlist.DataSource = ds.Tables[0];
            sqlcon.Close();

        }

        private void UyeGoruntuleme_Load(object sender, EventArgs e)
        {
            populasyon();
        }

        private void memberlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void memberlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
