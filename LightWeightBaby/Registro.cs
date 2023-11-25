using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrito_diseño
{
    public partial class registrovt : Form
    {
        loginvt Loginvt;

        public registrovt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginvt = new loginvt();
            Loginvt.Show();
        }
    }
}
