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
        List<string> values;

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
            binder.BindTo_ComboBox(cb_kunden, BL.getKunden(), r);
            if (cb_kunden.SelectedItem != null)
            {
                binder.BindTo_ComboBox(cb_projekt, BL.getProjekte(((Kunde)cb_kunden.SelectedItem).Kundenid), r);
            }
            binder.BindTo_TextBox(tb_rechnungid, r.Rechnungid);
            binder.BindTo_TextBox(tb_bezeichnung, r.Bezeichnung);
            binder.BindTo_DateTimePicker(dtp_datum, r.Datum.Value);
            binder.BindTo_ListView(lv_buchungen, BL.getBuchungen(r.Rechnungid));
            binder.BindTo_TextBox(tb_offen, BL.getOffeneSumme(r.Rechnungid).ToString("#0.00") + " Euro");
        }

        void BindToZeilen()
        {
            values = new List<string>();
            foreach (var item in BL.getRechnungszeilen(r.Rechnungid))
            {
                values.Add(item.Bezeichnung);
                values.Add(item.Betrag.ToString("#0.00") + " Euro");
            }
            binder.BindTo_ListView(lv_zeilen, BL.getRechnungszeilen(r.Rechnungid));
            binder.BindTo_TextBox(tb_rechnungssumme, BL.getRechnungssumme(r.Rechnungid).ToString("#0.00") + " Euro");
        }

        bool BindFrom()
        {
            binder.StartBindFrom();
            r.Bezeichnung = binder.BindFrom_String(tb_bezeichnung, errorControl1, new DataBinding.RequiredRule());
            r.Datum = binder.BindFrom_DateTime(dtp_datum, errorControl2, null);
            r.Kundenid = binder.BindFrom_ComboBox_Int(cb_kunden, errorControl6, new DataBinding.RequiredRule());
            r.Projektid = binder.BindFrom_ComboBox_Int(cb_projekt, errorControl3, new DataBinding.RequiredRule());

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
            rz.Status = ObjectStates.New;           

            if (binder.HasErrors)
                return false;

            return true;
        }

        private void RechnungDetail_Load(object sender, EventArgs e)
        {
            BindTo();
            if (created)
            {
                gb2.Enabled = false;
                gb3.Enabled = false;
            }
            BindToZeilen();
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            if (BindFrom())
            {
                if (r.Status != ObjectStates.Unmodified)
                {
                    BL.saveAusgang(r);
                    this.Close();
                }
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

        private void bn_new_buchung_Click(object sender, EventArgs e)
        {
            var tmp = new Dialogs.BuchungDetail();
            tmp.ShowDialog();
            BindTo();
            BindToZeilen();
        }

        void lv_buchungen_DoubleClick(object sender, System.EventArgs e)
        {
            var tmp = new Dialogs.BuchungDetail((Buchung)lv_buchungen.FocusedItem.Tag);
            tmp.ShowDialog();
            BindTo();
            BindToZeilen();
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void cb_kunden_SelectedIndexChanged(object sender, EventArgs e)
        {
            binder.BindTo_ComboBox(cb_projekt, BL.getProjekte(((Kunde)cb_kunden.SelectedItem).Kundenid), r);
            cb_projekt.Text = "";
        }

        private void bn_print_Click(object sender, EventArgs e)
        {
            sfd.FileName = r.Bezeichnung;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CreatePdf pdf = new CreatePdf();
                pdf.CreatePdfDocument(sfd.FileName);
                pdf.AddHeader(r.Bezeichnung);
                pdf.addTableRechnung(2, values, BL.getRechnungssumme(r.Rechnungid).ToString("#0.00") + " Euro");
                pdf.ClosePdf();
            }
        }

    }
}
