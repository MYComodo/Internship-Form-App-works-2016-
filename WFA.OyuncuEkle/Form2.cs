using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.OyuncuEkle
{
    public partial class Form2 : Form
    {

        public Form frm1;
        
        public Form2()
        {
            InitializeComponent();
            frm1 = (Form1)(Application.OpenForms["Form1"]);
            

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            List<Player> oyuncu = new List<Player>()
            {
                new Player
                {
                    //PlayerId = frm1.
                    //Email=tBMail.Text,
                    //NickName = tBName.Text
                }           

            };


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
