using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryans_Late_Fee_Calculator
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btnNewRelease_Click(object sender, EventArgs e)
        {
            newRelease obj = new newRelease();
            obj.Show();
        }

        private void btnKidsMovie_Click(object sender, EventArgs e)
        {
            KidsMovie obj = new KidsMovie();
            obj.Show();
        }

        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {
            LibraryMovie obj = new LibraryMovie();
            obj.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
