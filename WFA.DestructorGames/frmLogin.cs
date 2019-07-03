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
    public partial class frmLogin : BaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(txtUserName.Text, txtPassword.Text))
            {
                this.Hide();
                new frmMain().Show();
            }
            else
            {
                MessageBox.Show("Kulllanıcı Bilgileri Hatalı !");
            }
        }

        bool Login(string userName,string password)
        {
            using (StoreContext)
            {
                if(StoreContext.Users.Any(u=>u.UserName==userName&& u.Password == password))
                {
                    User = StoreContext.Users.First();
                    return true;
                }
                else
                {
                    return false;
                }               
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
