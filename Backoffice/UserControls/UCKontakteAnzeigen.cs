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

        void BindTo(string search = "")
        {
            DataBinding.Binder binder = new DataBinding.Binder();
            if (search == "")
            {
                binder.BindTo_ListView(lv_kontakte, BL.getKontakte());
            }
            else
            {
                binder.BindTo_ListView(lv_kontakte, BL.getKontakte(search));
            }
        }

        void NewKontakt()
        {
            var tmp = new Dialogs.KontaktDetail();
            tmp.ShowDialog();
            BindTo();
        }

        void EditKontakt(Kontakt k)
        {
            var tmp = new Dialogs.KontaktDetail(k);
            tmp.ShowDialog();
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

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            BindTo(tb_search.Text);
        }
    }
}
