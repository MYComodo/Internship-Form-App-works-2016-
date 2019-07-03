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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnGameAdd_Click(object sender, EventArgs e)
        {
            frmAddGame formAddGame = new frmAddGame();
            formAddGame.ShowDialog();
                
         }

        void ShowPlayer()
        {
            using(DbSaleStore salecontext = new DbSaleStore())
            {
                dgvShowPlayer.DataSource = null;
                dgvShowPlayer.DataSource = salecontext.Players.Select(p =>
                new
                {
                    OyuncuNo = p.PlayerId,
                    İsmi = p.PlayerName,
                    KayıtTarihi = p.RegistrationDate,
                    Hesabı = p.PlayerAccount



                }).ToList();
                dgvShowPlayer.Columns[0].HeaderText = "No";
                dgvShowPlayer.Columns[1].HeaderText = "İsim";
                dgvShowPlayer.Columns[2].HeaderText = "Kayıt Tarihi";
                dgvShowPlayer.Columns[3].HeaderText = "Bakiye";


            }
        }


        void ShowGame()
        {
            using (DbSaleStore salecontext = new DbSaleStore())
            {


                dvgShowGame.DataSource = null;
                dvgShowGame.DataSource = salecontext.Games.Select(g => new { GameId = g.GameId, GameName = g.GameName, GamePrice = g.GamePrice }).ToList();
        
          
              
            }
        }
    
        
        private void btnShowGame_Click(object sender, EventArgs e)
        {
            ShowGame();
        }

        private void btnShowPlayer_Click(object sender, EventArgs e)
        {
            ShowPlayer();

        }
    }
}
