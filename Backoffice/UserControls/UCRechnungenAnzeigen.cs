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
            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_ListView(lv_rechnungen, BL.getAusgaenge());
        }

        void EditRechnung(Ausgang r)
        {
            Dialogs.RechnungDetail tmp = new Dialogs.RechnungDetail(r);
            tmp.ShowDialog();
            BindTo();
        }

        void NewRechnung()
        {
            Dialogs.RechnungDetail tmp = new Dialogs.RechnungDetail();
            tmp.ShowDialog();
            BindTo();
        }

        void DeleteRechnung(Ausgang r)
        {
            BL.deleteAusgang(r);
            BindTo();
        }

        private void bn_new_Click(object sender, EventArgs e)
        {
            NewRechnung();
        }

        private void bn_edit_Click(object sender, EventArgs e)
        {
            if (lv_rechnungen.SelectedItems.Count == 1)
            {
                EditRechnung((Ausgang)lv_rechnungen.FocusedItem.Tag);
            }
        }

        private void bn_delete_Click(object sender, EventArgs e)
        {
            if (lv_rechnungen.SelectedItems.Count == 1)
            {
                DeleteRechnung((Ausgang)lv_rechnungen.FocusedItem.Tag);
            }
        }

        private void UCRechnungenAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void lv_rechnungen_DoubleClick(object sender, EventArgs e)
        {
            EditRechnung((Ausgang)lv_rechnungen.FocusedItem.Tag);
        }
    }
}
