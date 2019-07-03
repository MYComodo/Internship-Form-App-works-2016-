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
    public partial class frmPlayer : Form
    {
        


        
        public frmPlayer()
        {
            InitializeComponent();
            cbSortCondition.Items.Add("Ucuz");
            cbSortCondition.Items.Add("Pahalı");



        }

        private void btnGameBuy_Click(object sender, EventArgs e)
        {
            frmSaleGame formSaleGame = new frmSaleGame();
            formSaleGame.ShowDialog();

        }

        void SortbyPrice()
        {
            dgvGamePrice.DataSource = null;
            using(DbSaleStore salecontext = new DbSaleStore())
            {
                if (cbSortCondition.SelectedItem.ToString() == "Ucuz")
                {
                    dgvGamePrice.DataSource = salecontext.Games.Select(g=> new
                    { GamePrice = g.GamePrice,GameName=g.GameName }).OrderBy(g => g.GamePrice).ToList();
                 
                       
                }
                else
                {
                    dgvGamePrice.DataSource = salecontext.Games.Select(g => new
                    { GamePrice = g.GamePrice, GameName = g.GameName }).OrderByDescending(g=> g.GamePrice).ToList();
                }
            }

            dgvGamePrice.Columns[0].HeaderText = "Fiyat";
            dgvGamePrice.Columns[1].HeaderText = "Oyun";


        }

        private void btnPrice_Click(object sender, EventArgs e)
        {

            SortbyPrice();
        }

        private void frmPlayer_Load(object sender, EventArgs e)
        {
          
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            using(DbSaleStore salecontext=new DbSaleStore())
            {
                var updatecontext = salecontext.Players.First(p => p.IsActive == true);
                updatecontext.IsActive = false;
                salecontext.SaveChanges();
            }

        }
        private void frmPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }

    
    }
}
