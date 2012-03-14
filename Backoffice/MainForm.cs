using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Backoffice
{
    public partial class MainForm : Form
    {
        UserControls.UCKundenAnzeigen ka;

        public MainForm()
        {
            InitializeComponent();

            ka = new UserControls.UCKundenAnzeigen();
            this.Controls.Add(ka);
        }

        void DisplayUserControl(UserControl uc)
        {
            foreach (var item in this.Controls)
            {
                Type t = item.GetType();
                MessageBox.Show(t.ToString());
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alleKundenAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ka);
        }
    }
}
