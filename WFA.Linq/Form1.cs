using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNickName_TextChanged(object sender, EventArgs e)
        {
            ShowPlayer(txtNickName.Text);
        }

        void ShowPlayer(string nickName)
        {
            dgvPlayers.DataSource = null;

            dgvPlayers.DataSource =
                GetPlayers().Where(p => p.NickName.ToLower().Contains(nickName.ToLower())).ToList();
            // players.Where(item=>item.NickName==txtNickName.Text).ToList();
        }

        List<Player> GetPlayers()
        {
            List<Player> players = new List<Player> {
             new Player
            {
                NickName = "destructor",
            },
            new Player
            {
                NickName = "destructor2",
            },
            new Player
            {
                NickName = "İnsan",
            },
            new Player
            {
                NickName = "Human",
            },
            new Player
            {
                NickName = "Gamer",
            },
            new Player
            {
                NickName = "Soner",
            },
            new Player
            {
                NickName = "Ello Gov'Nor",
            }
        };

            return players;
        }

        private void dgvPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
