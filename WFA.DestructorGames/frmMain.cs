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
    public partial class frmMain : BaseForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            new frmAddPlayer().Show();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            new frmAddGame().Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            new frmSale().Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            new frmUpdatePlayer().Show();
        }

        bool UpdatePlayer()
        {

            return true;
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {

        }
    }
}
