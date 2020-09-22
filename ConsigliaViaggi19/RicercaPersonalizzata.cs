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
    public partial class RicercaPersonalizzata : Form
    {
        private string citta;
        private int mvalMin;
        private int mvalMax;

        public string Citta
        {
            get { return citta; }
            set { citta = value; }
        }

        public int MvalMin
        {
            get { return mvalMin; }
            set { mvalMin = value; }
        }

        public int MvalMax
        {
            get { return mvalMax; }
            set { mvalMax = value; }
        }

        public RicercaPersonalizzata()
        {
            InitializeComponent();
        }

        private void RicercaPersonalizzata_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void applica_Click(object sender, EventArgs e)
        {
            MvalMin = int.Parse(comboBoxMin.SelectedItem.ToString());
            MvalMax = int.Parse(comboBoxMax.SelectedItem.ToString());
            Citta = textBox1.Text;
         
            this.Close();
        }

        private void comboBoxMin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
