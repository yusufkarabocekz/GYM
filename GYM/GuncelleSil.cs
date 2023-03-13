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
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
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
            memberlist2.DataSource = ds.Tables[0];
            sqlcon.Close();

        }

        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            populasyon();
        }

        int key = 0;

        private void memberlist2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            key = Convert.ToInt32(memberlist2.SelectedRows[0].Cells[0].Value.ToString());




        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            nametext.Text = "";
            yastext.Text = "";
            phonetext.Text = "";
            amounttext.Text = "";
            timingcombo.Text = "";
            cinsiyetcombo.Text = "";

        }

        private void anamenubutton_Click(object sender, EventArgs e)
        {
            Form2 anamenu = new Form2();
            anamenu.Show();
            this.Hide();
        }



        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek olan üyeyi seçiniz");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string sorgulama = "delete form MemberTbl where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(sorgulama, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye silme işlemi başarıyla gerçekleştirildi.");
                    sqlcon.Close();
                    populasyon();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void populasyon(string v)
        {
            throw new NotImplementedException();
        }

        private void memberlist2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nametext.Text = memberlist2.CurrentRow.Cells[1].Value.ToString();
            phonetext.Text = memberlist2.CurrentRow.Cells[2].Value.ToString();
            cinsiyetcombo.Text = memberlist2.CurrentRow.Cells[3].Value.ToString();
            yastext.Text = memberlist2.CurrentRow.Cells[4].Value.ToString();
            amounttext.Text = memberlist2.CurrentRow.Cells[5].Value.ToString();
            timingcombo.Text = memberlist2.CurrentRow.Cells[6].Value.ToString();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (key == 0 || nametext.Text == "" || phonetext.Text == "" || yastext.Text == "" || amounttext.Text == "" || cinsiyetcombo.Text == "" || timingcombo.Text == "")
            {
                MessageBox.Show("Eksik bilgi girdiniz.");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string sorgulama = "update MemberTbl set MName ='" + nametext.Text + "', MPhone='" + phonetext.Text + "', MGen='" + cinsiyetcombo.Text + "',MAge=" + yastext.Text + ",MAmount=" + amounttext.Text + ",MTiming='" + timingcombo.Text + "'MId=" + key + ";";

                    SqlCommand cmd = new SqlCommand(sorgulama, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye silme işlemi başarıyla gerçekleştirildi.");
                    sqlcon.Close();
                    populasyon();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void form2exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
