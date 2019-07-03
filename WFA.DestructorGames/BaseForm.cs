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
    public partial class BaseForm : Form
    {
        public User User { get; set; }
        public DbDestructorStore StoreContext = new DbDestructorStore();
        public BaseForm()
        {          
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
