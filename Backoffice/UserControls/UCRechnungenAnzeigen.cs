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
    public partial class UCRechnungenAnzeigen : UserControl
    {
        public UCRechnungenAnzeigen()
        {
            InitializeComponent();
        }

        void BindTo()
        {
            lv_rechnungen.Items.Clear();
            foreach (var item in BL.getRechnungen())
            {
                ListViewItem i = lv_rechnungen.Items.Add(item.Rechnungid.ToString());
                i.Tag = item;
                i.SubItems.Add(item.Bezeichnung);
                i.SubItems.Add(item.Datum.ToShortDateString());
            }
        }

        void EditRechnung(Rechnung r)
        {
            Dialogs.RechnungDetail tmp = new Dialogs.RechnungDetail(r);
            if (tmp.ShowDialog() == DialogResult.OK)
                BindTo();
        }

        void NewRechnung()
        {
            Dialogs.RechnungDetail tmp = new Dialogs.RechnungDetail();
            if (tmp.ShowDialog() == DialogResult.OK)
                BindTo();
        }

        void DeleteRechnung(Rechnung r)
        {
            BL.deleteRechnung(r);
        }

        private void bn_new_Click(object sender, EventArgs e)
        {
            NewRechnung();
        }

        private void bn_edit_Click(object sender, EventArgs e)
        {
            if (lv_rechnungen.SelectedItems.Count == 1)
            {
                EditRechnung((Rechnung)lv_rechnungen.FocusedItem.Tag);
            }
        }

        private void bn_delete_Click(object sender, EventArgs e)
        {
            if (lv_rechnungen.SelectedItems.Count == 1)
            {
                DeleteRechnung((Rechnung)lv_rechnungen.FocusedItem.Tag);
            }
        }

        private void UCRechnungenAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void lv_rechnungen_DoubleClick(object sender, EventArgs e)
        {
            EditRechnung((Rechnung)lv_rechnungen.FocusedItem.Tag);
        }
    }
}
