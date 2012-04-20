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
    public partial class UCAngeboteAnzeigen : UserControl
    {
        public UCAngeboteAnzeigen()
        {
            InitializeComponent();
        }

        void BindTo()
        {
            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_ListView(lv_angebote, BL.getAngebote());
        }

        void NewAngebot()
        {
            Dialogs.AngebotDetail tmp = new Dialogs.AngebotDetail();
            if (tmp.ShowDialog() == DialogResult.OK)
                BindTo();
        }

        void EditAngebot(Angebot a)
        {
            Dialogs.AngebotDetail tmp = new Dialogs.AngebotDetail(a);
            if (tmp.ShowDialog() == DialogResult.OK)
                BindTo();
        }

        void DeleteAngebot(Angebot a)
        {
            BL.deleteAngebot(a);
            BindTo();
        }

        private void bn_new_Click(object sender, EventArgs e)
        {
            NewAngebot();
        }

        private void bn_edit_Click(object sender, EventArgs e)
        {
            if (lv_angebote.SelectedItems.Count == 1)
                EditAngebot((Angebot)lv_angebote.FocusedItem.Tag);
        }

        private void bn_delete_Click(object sender, EventArgs e)
        {
            if (lv_angebote.SelectedItems.Count == 1)
                DeleteAngebot((Angebot)lv_angebote.FocusedItem.Tag);
        }

        private void UCAngeboteAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void lv_angebote_DoubleClick(object sender, EventArgs e)
        {
            EditAngebot((Angebot)lv_angebote.FocusedItem.Tag);
        }
    }
}
