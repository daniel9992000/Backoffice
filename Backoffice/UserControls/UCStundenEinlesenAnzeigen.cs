using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backoffice.Dialogs
{
    public partial class UCStundenEinlesenAnzeigen : UserControl
    {
  
        public UCStundenEinlesenAnzeigen()
        {
            InitializeComponent();
        }

        private void UCStundenEinlesenAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        void Bindlist()
        {
            lv_stunden.Items.Clear();
            foreach (var tmp in BL.getStunden(cb_projekt.SelectedItem.ToString()))
            {
                ListViewItem i = lv_stunden.Items.Add(tmp.Projektname.ToString());
                i.Tag = tmp;
                i.SubItems.Add(tmp.Mitarbeiter);
                i.SubItems.Add(tmp.Stundenanz.ToString());
                i.SubItems.Add(tmp.Datum.ToShortDateString());
            }
        }

        void BindTo()
        {
            bool hilf = false;
            cb_projekt.Items.Clear();
            foreach (var item in BL.getProjekte())
            {
                cb_projekt.Items.Add(item);
                if (hilf == false)
                {
                    cb_projekt.SelectedItem = item;
                    hilf = true;
                }
                
            }
            
            
            lv_stunden.Items.Clear();
            foreach (var tmp in BL.getStunden(cb_projekt.SelectedItem.ToString()))
            {
                ListViewItem i = lv_stunden.Items.Add(tmp.Projektname.ToString());
                i.Tag = tmp;
                i.SubItems.Add(tmp.Mitarbeiter);
                i.SubItems.Add(tmp.Stundenanz.ToString());
                i.SubItems.Add(tmp.Datum.ToShortDateString());
            }
        }

        private void bnnew_Click(object sender, EventArgs e)
        {
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                StundenEinlesen mystund = new StundenEinlesen();
                mystund.readcsv(oFD.FileName);
            }
            Bindlist();
        }

        private void cb_projekt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bindlist();
        }

    }
}
