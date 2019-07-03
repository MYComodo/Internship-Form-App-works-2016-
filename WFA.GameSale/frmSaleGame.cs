using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA.GameSale.Models;

namespace WFA.GameSale
{
    public partial class frmSaleGame : Form
    {
       
        public frmSaleGame()
        {
            InitializeComponent();
        }

        bool BuyGame(Sale sales)
        {
            
            using (DbSaleStore salecontext = new DbSaleStore())
            {
                var player = salecontext.Players.Where(p => p.IsActive == true).First();
                var game = salecontext.Games.Where(g => g.GameName == cboGame.SelectedItem.ToString()).First();

                if (player.PlayerAccount>=game.GamePrice)
                {
                    sales = new Sale()
                    {
                        GameId = game.GameId,
                        PlayerId = player.PlayerId,
                        BuyMoney = game.GamePrice
                    };
                    var updatecontext = salecontext.Players.Where(p => p.IsActive == true).First();
                    updatecontext.PlayerAccount = player.PlayerAccount - game.GamePrice;

                    salecontext.SaveChanges();

                }

                else
                {
                    lblBuyReport.Text = "Bu Oyun İçin Yeterli Paranız Yoktur! ";
                }


                
            }
            return true;
        }

        

        private void btnBuyGame_Click(object sender, EventArgs e)
        {
            Sale sales=new Sale()
            {
                SaleId = Convert.ToInt32(cboGame.SelectedValue)
        };
            
            BuyGame(sales);

        }

        void GetGame()
        {
            using (DbSaleStore salecontext = new DbSaleStore())
            {
                cboGame.DataSource = salecontext.Games.ToList();
                cboGame.DisplayMember = "GameName";
                cboGame.ValueMember = "GameId";
            }
        }

        private void frmSaleGame_Load(object sender, EventArgs e)
        {
            GetGame();
        }

        //private void btnTest_Click(object sender, EventArgs e)
        //{
        //}
    }
}
