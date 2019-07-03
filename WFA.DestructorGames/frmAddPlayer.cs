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
    public partial class frmAddPlayer : BaseForm
    {
        public frmAddPlayer()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
           MessageBox.Show(AddPlayer()?"Kaydedildi...": "KAYDEDİLEMEDİ !");
        }

        bool AddPlayer()
        {
            using (DbDestructorStore context = new DbDestructorStore())
            {
                if (txtFullName!=null && txtNick!= null && txtPrice!=null && !(context.Players.Any(p=> p.FullName==txtFullName.Text)))
                {
                    var player = new Player
                    {
                        FullName = txtFullName.Text,
                        NickName = txtNick.Text,
                        Price = Convert.ToDecimal(txtPrice.Text),
                        RegisterationDate = DateTime.Now,
                        IsActive = true
                    };

                    context.Players.Add(player);
                    return context.SaveChanges() > 0;
                }

                else if(context.Players.Any(p=> p.NickName==txtNick.Text))
                {
                    MessageBox.Show("Girdiğiniz Nick Kullanımda !! ");
                }

                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz !! ");
                }
                return true;
            }
        }
    }
}
