using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kargosistemiyeni.Properties
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string[] il = new string[10] { "istanbul", "Ankara", "İzmir", "Konya", "Sivas", "Koacaeli", "Balıkesir", "Edirne", "Bolu", "Muş" };
            comboBox1.Items.AddRange(il);

            comboBox2.Items.AddRange(il);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                    
                
                
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.ShowDialog();
            this.Hide();
        }
    }
} 
