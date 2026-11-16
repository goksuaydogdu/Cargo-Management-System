using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kargosistemiyeni.Properties
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Double en, boy, KG, sonuc;
            en = Convert.ToDouble(textBox1.Text);
            boy=Convert.ToDouble (textBox2.Text); 
            KG=Convert.ToDouble (textBox3.Text);

            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Double en, boy, KG,sonuc;
            en = 50;
            boy = 50;
            KG = 50;

           sonuc = (en * boy * KG);

            if (sonuc >= 20 && sonuc <= 200)
            {
                textBox4.Text = "Ödemeniz gereken ücret 50 TL";
            }

            else if (sonuc > 200 && sonuc <= 800)
            {
                textBox4.Text = "Ödemeniz gereken ücret 65 TL";
            }

            else if (sonuc > 800 && sonuc <= 1600)
            {
                textBox4.Text = "Ödemeniz gereken ücret 85 TL";
            }
            else if (sonuc > 1600 && sonuc <= 3200)
            {
                textBox4.Text = "Ödemeniz gereken ücret 100TL";
            }
            else if (sonuc > 3200 && sonuc <= 6400)
            {
                textBox4.Text = "Ödemeniz gereken ücret 120 TL";
            }
            else if (sonuc > 6400 && sonuc <= 12800)
            {
                textBox4.Text = "Ödemeniz gereken ücret 150TL";
            }
            else if (sonuc > 12800 && sonuc <= 25600)
            {
                textBox4.Text = "Ödemeniz gereken ücret 175TL";
            }
            else if (sonuc > 25600 && sonuc <= 51200)
            {
                textBox4.Text = "Ödemeniz gereken ücret 200 TL";
            }
        }
    }
}
