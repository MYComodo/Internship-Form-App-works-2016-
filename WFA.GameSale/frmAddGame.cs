using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA.GameSale.Models;

namespace WFA.GameSale
{
    public partial class frmAddGame : Form
    {

        frmSaleGame formsale = (frmSaleGame)Application.OpenForms["frmSaleGame"];
        
        public frmAddGame()
        {
            InitializeComponent();
        }

        void AddGame(Game games)
        { 
            using (DbSaleStore salecontext = new DbSaleStore())
            {
                if (salecontext.Games.Any(g => g.GameName == txtAddGameName.Text))
                {
                    MessageBox.Show("Bu oyun zaten var !", "Uyarı ");
                }
                else
                {
                    salecontext.Games.Add(games);
                    salecontext.SaveChanges();
                }
            }

        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            Game games = new Game()
            {
                GameName = txtAddGameName.Text,
                GamePrice = Convert.ToDecimal((txtAddGamePrice.Text))

            };
            
            AddGame(games);
        }
    }
}
