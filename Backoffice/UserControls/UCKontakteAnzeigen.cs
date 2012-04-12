using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backoffice.UserControls
{
    public partial class UCKontakteAnzeigen : UserControl
    {
        public UCKontakteAnzeigen()
        {
            InitializeComponent();
        }

        void BindTo()
        {
            lv_kontakte.Items.Clear();
            foreach (var tmp in BL.getKontakte())
            {
                ListViewItem i = lv_kontakte.Items.Add(tmp.Kontaktid.ToString());
                i.Tag = tmp;
                i.SubItems.Add(tmp.Firmenname);
                i.SubItems.Add(tmp.Vorname);
                i.SubItems.Add(tmp.Nachname);
                i.SubItems.Add(tmp.Email);
                i.SubItems.Add(tmp.Adresse);
                i.SubItems.Add(tmp.Hausnummer);
                i.SubItems.Add(tmp.Plz);
                i.SubItems.Add(tmp.Ort);
            }
        }

        void NewKontakt()
        {
            var tmp = new Dialogs.KontaktDetail();
            if (tmp.ShowDialog() == DialogResult.OK)
                BindTo();
        }

        void EditKontakt(Kontakt k)
        {
            var tmp = new Dialogs.KontaktDetail(k);
            if (tmp.ShowDialog() == DialogResult.OK)
                BindTo();
        }

        void DeleteKontakt(Kontakt k)
        {
            BL.deleteKontakt(k);
            BindTo();
        }

        private void bnnew_Click(object sender, EventArgs e)
        {
            NewKontakt();
        }

        private void bnedit_Click(object sender, EventArgs e)
        {
            if (lv_kontakte.SelectedItems.Count == 1)
            {
                EditKontakt((Kontakt)lv_kontakte.FocusedItem.Tag);
            }
        }

        private void bndelete_Click(object sender, EventArgs e)
        {
            if (lv_kontakte.SelectedItems.Count == 1)
            {
                DeleteKontakt((Kontakt)lv_kontakte.FocusedItem.Tag);
            }

        }

        private void lv_kontakte_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditKontakt((Kontakt)lv_kontakte.FocusedItem.Tag);
        }

        private void UCKontakteAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
