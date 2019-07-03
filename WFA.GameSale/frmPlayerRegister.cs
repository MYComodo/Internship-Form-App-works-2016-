using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using WFA.GameSale.Models;

namespace WFA.GameSale
{
    public partial class frmPlayerRegister : Form
    {
        public frmPlayerRegister()
        {
            InitializeComponent();
        }

        private void btnRegisterPlayer_Click(object sender, EventArgs e)
        {
            Player playerlist = new Player()
            {
                PlayerName = txtRegisterName.Text,
                PlayerMail = txtRegisterMail.Text,
                Password = txtRegisterPassword.Text,
                PlayerAccount = Convert.ToDecimal(txtRegisterCoin.Text),
                RegistrationDate = DateTime.Now,
                IsActive = true
                

            };
            using(DbSaleStore salecontext = new DbSaleStore())
            {
                salecontext.Players.Add(playerlist);

                salecontext.SaveChanges();
            }
        }
    }
}
