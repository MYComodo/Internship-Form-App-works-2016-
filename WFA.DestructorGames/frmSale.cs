using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA.DestructorGames.Models;

namespace WFA.DestructorGames
{
    public partial class frmSale : BaseForm
    {
        public frmSale()
        {
            InitializeComponent();
            GetPlayers();
            GetGames();
        }

        void GetPlayers()
        {
            using (DbDestructorStore context = new DbDestructorStore())
            {
                cmbPlayer.DataSource = context.Players.ToList();
                cmbPlayer.DisplayMember = "FullName";
                cmbPlayer.ValueMember = "PlayerId";
            }
        }

        void GetGames()
        {
            using (DbDestructorStore context = new DbDestructorStore())
            {
                cmbGame.DataSource = context.Games.ToList();
                cmbGame.DisplayMember = "Name";
                cmbGame.ValueMember = "GameId";
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Sale() ? "Kaydedildi..." : "KAYDEDİLEMEDİ !");
        }

        bool Sale()
        {
            using (DbDestructorStore context = new DbDestructorStore())
            {
                var gameId = Convert.ToInt32(cmbGame.SelectedValue);//Combodan Al
                var game = context.Games.First(g => g.GameId == gameId);//Db Den Getir

                var sale = new Sale
                {
                    PlayerId = Convert.ToInt32(cmbPlayer.SelectedValue),
                    GameId = game.GameId,
                    Price = game.ListPrice,
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    SaleDate = DateTime.Now,
                    IsActive = true
                };

                context.Sales.Add(sale);
                return context.SaveChanges() > 0;
            }
        }
    }
}
