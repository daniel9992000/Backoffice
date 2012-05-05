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
            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_ListView(lv_stunden, BL.getStunden(cb_projekt.SelectedItem.ToString()));
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

            Bindlist();
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
