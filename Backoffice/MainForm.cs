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
        List<UserControl> guiControls;

        public MainForm()
        {
            InitializeComponent();
            guiControls = new List<UserControl>();
            guiControls.Add(uc_kundenAnzeigen);
            guiControls.Add(ucProjekteAnzeigen1);
            guiControls.Add(ucAngeboteAnzeigen1);
            guiControls.Add(ucKontakteAnzeigen1);

            foreach (var item in guiControls)
            {
                item.Hide();
            }
            
        }

        void DisplayUserControl(UserControl uc)
        {
            foreach (var item in guiControls)
            {
                item.Hide();
                if (item == uc)
                    item.Show();
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
            DisplayUserControl(uc_kundenAnzeigen);
        }

        private void neuerKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projekteToolStripMenuItem_Click(object sender, EventArgs e)
        {           
           
        }

        private void alleAngeboteAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucAngeboteAnzeigen1);
        }

        private void projektAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucProjekteAnzeigen1);
        }

        private void kontakteAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucKontakteAnzeigen1);
        }
    }
}
