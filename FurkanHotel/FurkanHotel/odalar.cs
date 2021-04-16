using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurkanHotel
{
    public partial class odalar : Form
    {
        public odalar()
        {
            InitializeComponent();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            anaMenu anaMenu = new anaMenu();
            anaMenu.Show();
            this.Close();
        }
    }
}
