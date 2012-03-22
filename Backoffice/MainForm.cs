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
        public MainForm()
        {
            InitializeComponent();
            uc_kundenAnzeigen.Hide();
            ucProjekteAnzeigen1.Hide();
        }

        void DisplayUserControl(UserControl uc)
        {
            uc.Show();
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
            ucProjekteAnzeigen1.Hide();
            DisplayUserControl(uc_kundenAnzeigen);
        }

        private void neuerKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projekteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uc_kundenAnzeigen.Hide();
            DisplayUserControl(ucProjekteAnzeigen1);
        }
    }
}
