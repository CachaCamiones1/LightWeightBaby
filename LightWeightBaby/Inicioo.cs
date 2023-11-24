using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightWeightBaby
{
    public partial class webb : Form
    {
        kzcastorvt ingresarr;

        public webb()
        {
            InitializeComponent();
        }

        private void kzcastorbt_Click(object sender, EventArgs e)
        {
            // Cerrar la ventana actual
              
            // Abrir una nueva ventana
            ingresarr = new kzcastorvt();
            ingresarr.Show();
            this.Hide();
            
        }
    }
}
