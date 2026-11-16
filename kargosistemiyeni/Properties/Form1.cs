using kargosistemiyeni.Properties;
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

namespace kargosistemiyeni
{
    public partial class Form1 : Form
    {
        //kullanacağınız formlara ekleyin                
        SqlConnection conn = new SqlConnection("Data Source=YOUR_SERVER\\SQLEXPRESS;Initial Catalog=KargoTakip;Integrated Security=True;Encrypt=False");
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            // result gives the -1 output.. but on insert its 1
            //select * = o  tablodaki bütün objeleri çeker 
            //kullanici = "Select * from kullanici where email = email"
            //kargo = select * from kargo where kullaniciid = kullanici.id"Select * from kullanici where id = textbox1.value""Select * from kullanici where id = textbox1.value"
            //kargo.takipnumarası
            using (SqlCommand command = new SqlCommand("Select * from kullanici where id = textbox1.value", conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Veritabanından gelen adları Console'a yazdır
                    while (reader.Read())
                    {
                        string ad = reader["id"].ToString();
                        Console.WriteLine("Ad: " + ad);
                    }
                }
            }

            conn.Close();
            Form7 süre = new Form7();
            süre.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 uye_olma = new Form2();
            uye_olma.Show();
            this.Hide();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 yönetici_giris = new Form4();
            yönetici_giris.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = true; button4.Visible = true;
            Form3 kontrol=new Form3();
            kontrol.ShowDialog();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState==CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
            }
            else if(CheckBox1.CheckState==CheckState.Checked)
            {
                txtSifre
            }
        }
    }
}
