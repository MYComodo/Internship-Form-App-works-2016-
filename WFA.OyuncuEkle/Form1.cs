using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.OyuncuEkle
{
    public partial class Form1 : Form
    {
     // public Form2 frm2;
        public Form1()
        {
            InitializeComponent();
            

        }


        public int selectedNo;
        public int selectedNo2;

        public List<Player> players = new List<Player>();
        public List<Game> games = new List<Game>();

         List<Player> AddPlayer(int playerId, string nickName, string email)
        {
            List<Player> oyuncular = new List<Player>()
            {
                new Player
                {
                    PlayerId=playerId,
                    NickName=nickName,
                    Email=email

                }


            };
            return oyuncular;
        }

         List<Game>  AddGame(int gameId,string gameName,string difficulty)
        {
            List<Game> oyunlar = new List<Game>()
            {
                new Game
                {
                    GameId=gameId,
                    GameName=gameName,
                    Difficulty=difficulty
                }
            };

            return oyunlar;
        }

        public void OyuncuGoster()
        {
            
            Grid.DataSource = null;
            Grid.DataSource = players.OrderBy(p=> p.PlayerId).ToList();

            Grid.Columns[0].HeaderText = "Oyuncu No";
            Grid.Columns[1].HeaderText = "Oyuncu Adı";
            Grid.Columns[2].HeaderText = "Oyuncu Maili";

            

        }

        public List<Player> PlistDon()
        { 
            return players;
           
        }
        public List<Game> GlistDon()
        {
            return games;
        }

        public bool OyunKontrol()
        {
            // bool test=true;
            int a;

            a = games.Where(p => p.GameId == Convert.ToInt32(t_oyunNo.Text)).Count();

            if (a > 0 && t_oyunadi == null && t_zorluk == null && t_oyunNo == null)
            {
                MessageBox.Show("Girilen Numarada Daha Önce Bir Kayıt Bulunmaktadır !! Başka Bir Numara Giriniz..");
                // test = false;
            }
            else
                games.AddRange(AddGame(Convert.ToInt32(t_oyunNo.Text), t_oyunadi.Text, t_zorluk.Text));

            return true;
        }
        public bool OyuncuKontrol()
        {
           // bool test=true;
            int a;

            a = players.Where(p => p.PlayerId == Convert.ToInt32(tbID.Text)).Count();

            if(a>0)
            {
                MessageBox.Show("Girilen Numarada Daha Önce Bir Kayıt Bulunmaktadır !! Başka Bir Numara Giriniz..");
               // test = false;
            }
           else
                players.AddRange(AddPlayer(Convert.ToInt32(tbID.Text), tbNName.Text, tbEmail.Text));

            return true;
        }

        /*void Ekle(int no,string ad,string mail)
        {


            AddPlayer(no, ad, mail);


        }*/

        public void  OyuncuGuncelle(string nName,string eMail,List<Player> plist)
        {
           

            var test = plist.Where(p=> p.PlayerId==selectedNo).FirstOrDefault(p=> p.PlayerId==selectedNo);

            test.PlayerId = selectedNo;
              test.NickName = nName.ToString();
              test.Email = eMail.ToString();

        }
        public void OyunSil(int id)
        {
            int indexfind2 = games.FindIndex(g => g.GameId == id);

            games.RemoveAt(indexfind2);

        }

        public void OyuncuSil(int id)
        {
            int indexfind = players.FindIndex(p=> p.PlayerId==id);

            players.RemoveAt(indexfind);
        
        }
    
        public void OyunGoster()
        {
            Grid2.DataSource = null;
            Grid2.DataSource = games.ToList();

            Grid2.Columns[0].HeaderText = "Oyun No";
            Grid2.Columns[1].HeaderText = "Oyun Adı";
            Grid2.Columns[2].HeaderText = "Zorluk ";

        }


        public void OyunGuncelle(string nName, string diff, List<Game> plist)
        {
            var test = plist.Where(p => p.GameId == selectedNo).FirstOrDefault(p => p.GameId == selectedNo);

            test.GameName = nName.ToString();
            test.Difficulty = diff.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            OyuncuKontrol();
            OyuncuGoster();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2 frm2 = new Form2();
            //frm2.ShowDialog();

            OyuncuGuncelle(tbNName.Text, tbEmail.Text, players);
            OyuncuGoster();

        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedNo =  (int)Grid.SelectedRows[0].Cells[0].Value;
            tbID.Text = selectedNo.ToString();
            tbEmail.Text = Grid.SelectedRows[0].Cells[1].Value.ToString();
            tbNName.Text = Grid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void tbNName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OyuncuSil(selectedNo);
            OyuncuGoster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OyunKontrol();

            //games = AddGame(Convert.ToInt32(t_oyunNo.Text),t_oyunadi.Text,t_zorluk.Text);
            OyunGoster();
        }

        private void t_oyunNo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void t_oyunNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void t_oyunadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void t_zorluk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OyunGoster();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OyuncuGoster();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OyunGuncelle(t_oyunadi.Text, t_zorluk.Text, games);
            OyunGoster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            selectedNo2 = (int)Grid2.SelectedRows[0].Cells[0].Value;
            t_oyunNo.Text = selectedNo2.ToString();
            t_oyunadi.Text = Grid2.SelectedRows[0].Cells[1].Value.ToString();
            t_zorluk.Text = Grid2.SelectedRows[0].Cells[2].Value.ToString();




        }

        private void button9_Click(object sender, EventArgs e)
        {
            OyunSil(selectedNo2);
        }
    }
}
