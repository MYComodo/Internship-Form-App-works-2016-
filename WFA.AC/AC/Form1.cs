using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC
{
    public partial class Form1 : Form
    {
        AssassinsCreed Ezio = new AssassinsCreed("Ezio", 185.00, 28, 85);
       // AssassinsCreed Altair = new AssassinsCreed("Altair", 190.00, 89, 75);   

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ezio.dusman_cani = 500;
            Ezio.as_can = 500;
            label4.Text = Ezio.as_can.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ezio.as_can = 500;
            //AssassinsCreed Ezio = new AssassinsCreed("Ezio", 185.00, 28, 85, 500);
            label7.Text = Ezio.dusman_cani.ToString();
            label4.Text = Ezio.as_can.ToString();
            Ezio.Atack(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Ezio.as_can, listBox1.SelectedItem.ToString());
            label4.Text = Ezio.as_can.ToString();
            label7.Text = Ezio.dusman_cani.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AssassinsCreed Ezio = new AssassinsCreed("Ezio", 185.00, 28, 85, 500);
            Ezio.Iyilestir();
            label4.Text = Ezio.as_can.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ezio.SaldiriRaporu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ezio.SilahGucleri();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
