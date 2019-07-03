using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.DestructorGames
{
    public partial class frmUpdatePlayer : BaseForm
    {
        int selectedNo;
        public frmUpdatePlayer()
        {
            InitializeComponent();
            ShowPlayer();
        }

        void ShowPlayer()
        {
            using (StoreContext)
            {
                dgvShowPlayer.DataSource = StoreContext.Players.Select(p => new
                {
                    PlayerId = p.PlayerId,
                    FullName = p.FullName,
                    NickName = p.NickName,
                    Price = p.Price,
                    RegistirationDate = p.RegisterationDate,
                    IsActive = p.IsActive
                }).ToList();

                dgvShowPlayer.Columns[0].HeaderText = "No";
                dgvShowPlayer.Columns[1].HeaderText = "Tam Adı";
                dgvShowPlayer.Columns[2].HeaderText = "Takma Adı";
                dgvShowPlayer.Columns[3].HeaderText = "Cüzdanı";
                dgvShowPlayer.Columns[4].HeaderText = "Kayıt Tarihi";
                dgvShowPlayer.Columns[5].HeaderText = "Aktiflik";
            }
        }

        bool UpdatePlayer()
        {

            using (StoreContext)
            {
                var updatecontext = StoreContext.Players.Where(p => p.PlayerId == selectedNo).First();
                updatecontext.FullName = txtFullName.Text;
                updatecontext.NickName = txtNick.Text;
                updatecontext.Price = Convert.ToDecimal(txtPrice.Text);

                return StoreContext.SaveChanges() > 0;
            }
        }
      

        private void frmUpdatePlayer_Load(object sender, EventArgs e)
        {

        }

        private void frmUpdatePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvShowPlayer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedNo = Convert.ToInt32(dgvShowPlayer.SelectedRows[0].Cells[0].Value);
            txtFullName.Text = dgvShowPlayer.SelectedRows[0].Cells[1].Value.ToString();
            txtNick.Text = dgvShowPlayer.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = dgvShowPlayer.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btnRegUpdatePlayer_Click(object sender, EventArgs e)
        {

            MessageBox.Show(UpdatePlayer()?"Güncellendi..":"GÜNCELLENEMEDİ !! ");
        }

        private void dgvShowPlayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
