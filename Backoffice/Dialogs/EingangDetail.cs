using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Backoffice.Dialogs
{
    public partial class EingangDetail : Form
    {
        Eingang r = null;
        bool created = false;
        DataBinding.Binder binder;

        public EingangDetail()
        {
            InitializeComponent();
            r = new Eingang();
            created = true;
            binder = new DataBinding.Binder();
        }

        public EingangDetail(Eingang r)
        {
            InitializeComponent();
            this.r = r;
            binder = new DataBinding.Binder();
        }

        void BindTo()
        {
            binder.BindTo_ComboBox(cb_kontakt, BL.getKontakte(), r);
            binder.BindTo_TextBox(tb_rechnungid, r.Rechnungid);
            binder.BindTo_TextBox(tb_bezeichnung, r.Bezeichnung);
            binder.BindTo_TextBox(tb_betrag, r.Betrag.ToString("#0.00"));
            binder.BindTo_DateTimePicker(dtp_datum, r.Datum.Value);
            binder.BindTo_TextBox(tb_pfad, r.Path);
            binder.BindTo_ListView(lv_buchungen, BL.getBuchungen(r.Rechnungid));
        }

        bool BindFrom()
        {
            binder.StartBindFrom();
            r.Bezeichnung = binder.BindFrom_String(tb_bezeichnung, errorControl1, new DataBinding.RequiredRule());
            r.Datum = binder.BindFrom_DateTime(dtp_datum, errorControl2, null);
            r.Betrag = binder.BindFrom_Double(tb_betrag, errorControl5, new DataBinding.RequiredRule());
            r.Kontaktid = binder.BindFrom_ComboBox_Int(cb_kontakt, errorControl3, new DataBinding.RequiredRule());
            r.Path = binder.BindFrom_String(tb_pfad,errorControl4, new DataBinding.RequiredRule());
            
                        if (created) r.Status = ObjectStates.New;

            if (binder.HasErrors)
                return false;

            return true;
        }


        private void bnchooserech_Click(object sender, EventArgs e)
        {
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                tb_pfad.Text = oFD.FileName;
            }
        }

        private void EingangDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            if (BindFrom())
            {
                if (r.Status != ObjectStates.Unmodified)
                {
                    BL.saveEingang(r);
                }
                this.Close();
            }
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bn_new_buchung_Click(object sender, EventArgs e)
        {
            Dialogs.BuchungDetail tmp = new BuchungDetail();
            tmp.ShowDialog();
            BindTo();
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void lv_buchungen_DoubleClick(object sender, EventArgs e)
        {
            Dialogs.BuchungDetail tmp = new BuchungDetail((Buchung)lv_buchungen.FocusedItem.Tag);
            tmp.ShowDialog();
            BindTo();
        }
    }
}
