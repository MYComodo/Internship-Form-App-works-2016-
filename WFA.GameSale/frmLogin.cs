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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPlayerRegister formReg = new frmPlayerRegister();

            formReg.ShowDialog();


        }

        bool AdminControl()
        {
            if(txtLoginName.Text=="Admin" && txtLoginPassword.Text == "Admin" )
             return true;
                
            
            else
                return false;

            
        }

        bool PlayerControl()
        {
            using(DbSaleStore salecontext = new DbSaleStore())
            {
               
                if (salecontext.Players.Any(p=> p.PlayerName == txtLoginName.Text)&&salecontext.Players.Any(p=> p.Password == txtLoginPassword.Text))
                {

                    var updatingcontext = salecontext.Players.First(p => p.PlayerName == txtLoginName.Text);
                    updatingcontext.IsActive = true;



                    txtLoginName.Text = string.Empty;
                    txtLoginPassword.Text = string.Empty;
                    salecontext.SaveChanges();

                    MessageBox.Show("Hesabınıza başarılı şekilde bağlandınız .");
                    frmPlayer formplayer = new frmPlayer();
                    formplayer.ShowDialog();


                }

                else if (AdminControl())
                {
                    frmAdmin formadmin = new frmAdmin();
                    MessageBox.Show("Yönetici Girişi Yaptınız ! ");
                    formadmin.ShowDialog();
                    

                    txtLoginName.Text = string.Empty;
                    txtLoginPassword.Text = string.Empty;

                }

                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı! ");
                    txtLoginName.Text = string.Empty;
                    txtLoginPassword.Text = string.Empty;
                }

            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            PlayerControl();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
