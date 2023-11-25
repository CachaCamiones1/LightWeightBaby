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
    public partial class carritovt : Form
    {

        loginvt loginvt;
        public carritovt()
        {
            InitializeComponent();
        }

        private void paybutton_Click(object sender, EventArgs e)
        {
            loginvt = new loginvt();
            loginvt.Show();
        }
    }
}
