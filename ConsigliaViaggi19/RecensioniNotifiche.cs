using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsigliaViaggi19
{
    public partial class RecensioniNotifiche : Form
    {
        public RecensioniNotifiche()
        {
            InitializeComponent();
        }

        private void RecensioniNotifiche_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void menuPrincipale_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
