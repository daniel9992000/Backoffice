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
    public partial class UCBuchungenAnzeigen : UserControl
    {
        public UCBuchungenAnzeigen()
        {
            InitializeComponent();
        }

        void BindTo()
        {
            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_ListView(lv_buchungen, BL.getBuchungen());
        }

        void NewBuchung()
        {
            Dialogs.BuchungDetail tmp = new Dialogs.BuchungDetail();
            tmp.ShowDialog();
            BindTo();
        }

        void EditBuchung(Buchung b)
        {
            Dialogs.BuchungDetail tmp = new Dialogs.BuchungDetail(b);
            tmp.ShowDialog();
            BindTo();
        }

        void DeleteBuchung(Buchung b)
        {
            BL.deleteBuchung(b);
            BindTo();
        }

        private void bn_new_Click(object sender, EventArgs e)
        {
            NewBuchung();
        }

        private void bn_edit_Click(object sender, EventArgs e)
        {
            if (lv_buchungen.SelectedItems.Count == 1)
            {
                EditBuchung((Buchung)lv_buchungen.FocusedItem.Tag);
            }
        }

        private void bn_delete_Click(object sender, EventArgs e)
        {
            if (lv_buchungen.SelectedItems.Count == 1)
            {
                DeleteBuchung((Buchung)lv_buchungen.FocusedItem.Tag);
            }
        }

        private void UCBuchungenAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void lv_buchungen_DoubleClick(object sender, EventArgs e)
        {
            EditBuchung((Buchung)lv_buchungen.FocusedItem.Tag);
        }
    }
}
