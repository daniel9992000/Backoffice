using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backoffice.Dialogs
{
    public partial class RechnungDetail : Form
    {
        Ausgang r = null;
        Rechnungszeile rz = null;
        bool created = false;
        DataBinding.Binder binder;

        public RechnungDetail()
        {
            InitializeComponent();
            r = new Ausgang();
            created = true;
            binder = new DataBinding.Binder();
        }

        public RechnungDetail(Ausgang r)
        {
            InitializeComponent();
            this.r = r;
            binder = new DataBinding.Binder();
        }

        void BindTo()
        {
            binder.BindTo_ComboBox(cb_projekt, BL.getProjekte(), r);
            binder.BindTo_TextBox(tb_rechnungid, r.Rechnungid);
            binder.BindTo_TextBox(tb_bezeichnung, r.Bezeichnung);
            binder.BindTo_TextBox(tb_kunde, BL.getKunde(r.Kundenid));
            binder.BindTo_DateTimePicker(dtp_datum, r.Datum.Value);
            binder.BindTo_ListView(lv_buchungen, BL.getBuchungen(r.Rechnungid));
        }

        void BindToZeilen()
        {
            binder.BindTo_ListView(lv_zeilen, BL.getRechnungszeilen(r.Rechnungid));
        }

        bool BindFrom()
        {
            binder.StartBindFrom();
            r.Bezeichnung = binder.BindFrom_String(tb_bezeichnung, errorControl1, new DataBinding.RequiredRule());
            r.Datum = binder.BindFrom_DateTime(dtp_datum, errorControl2, null);

            if((r.Projektid = binder.BindFrom_ComboBox_Int(cb_projekt, errorControl3, new DataBinding.RequiredRule())) != 0)
            {            
                r.Kundenid = BL.getAngebot(r.Projektid).Kundenid;
            }

            if (created) r.Status = ObjectStates.New;

            if (binder.HasErrors)
                return false;

            return true;
        }

        bool BindFromZeilen()
        {
            rz = new Rechnungszeile();

            binder.StartBindFrom();
            rz.Bezeichnung = binder.BindFrom_String(tb_rz_bezeichnung, errorControl4, new DataBinding.RequiredRule());
            rz.Betrag = binder.BindFrom_Double(tb_rz_wert, errorControl5, new DataBinding.PositiveRule());
            rz.Rechnungid = r.Rechnungid;
            rz.Angebotid = BL.getAngebot(r.Projektid).Angebotid;
            rz.Status = ObjectStates.New;

            if (binder.HasErrors)
                return false;

            return true;
        }

        private void RechnungDetail_Load(object sender, EventArgs e)
        {
            BindTo();
            if (created)
                gb2.Enabled = false;
            BindToZeilen();
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            if (BindFrom())
            {
                BL.saveAusgang(r);
                this.Close();
            }
        }

        private void bn_add_Click(object sender, EventArgs e)
        {
            if (BindFromZeilen())
            {
                BL.saveRechnungszeile(rz);
                BindToZeilen();
            }
        }

        private void lv_zeilen_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Delete)
            {               
                if (lv_zeilen.SelectedItems.Count == 1)
                {
                    BL.deleteRechnungszeile((Rechnungszeile)lv_zeilen.FocusedItem.Tag);
                    BindToZeilen();
                }
            }
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
