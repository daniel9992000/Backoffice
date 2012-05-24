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
            guiControls.Add(ucRechnungenAnzeigen1);
            guiControls.Add(ucJahresumsatzAnzeigen1);
            guiControls.Add(ucEinahmenAusgabenAnzeigen1);
            guiControls.Add(ucOffeneProjekteAnzeigen1);
            guiControls.Add(ucOffeneRechnungenAnzeigen1);
            guiControls.Add(ucStundensatzAnzeigen1);
            guiControls.Add(ucEingangAnzeigen1);
            guiControls.Add(ucStundenEinlesenAnzeigen1);
            guiControls.Add(ucBuchungenAnzeigen1);

            foreach (var item in guiControls)
            {
                item.Hide();
            }
            BL.ConfigureLogger();            
        }

        void DisplayUserControl(UserControl uc)
        {
            foreach (var item in guiControls)
            {
                item.Hide();
                if (item == uc)
                {
                    item.Show();
                }
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

        private void rechnungenAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucRechnungenAnzeigen1);
        }

        private void prognostizierterJahresumsatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucJahresumsatzAnzeigen1);
        }

        private void aktuelleEinnahmenAusgabenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucEinahmenAusgabenAnzeigen1);
        }

        private void offeneProjekteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucOffeneProjekteAnzeigen1);
        }

        private void offeneRechnungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucOffeneRechnungenAnzeigen1);
        }

        private void stundensatzProjektToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucStundensatzAnzeigen1);
        }

        private void eingangsrechnungenAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucEingangAnzeigen1);
        }

        private void stundenEinlesenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucStundenEinlesenAnzeigen1);
        }

        private void buchungenAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ucBuchungenAnzeigen1);
        }
    }
}
