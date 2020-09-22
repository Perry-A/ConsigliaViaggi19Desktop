using ConsigliaViaggi19App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsigliaViaggi19
{
    public partial class MenuPrincipale : Form
    {

        public MenuPrincipale()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            InitTitle();
            InitTipiStrutture();
        }

        private void InitTitle()
        {
            Text = $"ConsigliaViaggi19 - {UsernameAmministratore}";
        }

        private void InitTipiStrutture()
        {
            try
            {
                tipiStruttureComboBox.Items.Clear();
                string[] tipiStrutture = Queries.GetTipiStrutture().ToArray();
                tipiStruttureComboBox.Items.AddRange(tipiStrutture);
                tipiStruttureComboBox.Items.Add("Tutti i tipi");
                tipiStruttureComboBox.SelectedIndex = tipiStruttureComboBox.Items.Count - 1;
            }
            catch(SqlException)
            {
                MessageBox.Show("Errore", "Connessione assente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public string UsernameAmministratore { get; set; }
    }
}
