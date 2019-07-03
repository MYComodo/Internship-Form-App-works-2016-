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
    public partial class frmAddGame : BaseForm
    {
        public frmAddGame()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AddGame() ? "Kaydedildi..." : "KAYDEDİLEMEDİ !");
        }

        bool AddGame()
        {
            using (DbDestructorStore context = new DbDestructorStore())
            {
                var game = new Game
                {
                    Name = txtName.Text,
                    ListPrice = Convert.ToInt32(txtListPrice.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    StockDate = Convert.ToDateTime(dtStockDate.Value),
                    IsActive = true
                };

                context.Games.Add(game);
                return context.SaveChanges() > 0;
            }
        }
    }
}
