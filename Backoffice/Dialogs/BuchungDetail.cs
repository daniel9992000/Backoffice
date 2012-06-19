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
    public partial class BuchungDetail : Form
    {
        DataBinding.Binder binder;
        bool created;
        Buchung b;
        public BuchungDetail()
        {
            InitializeComponent();
            binder = new DataBinding.Binder();
            b = new Buchung();
            created = true;
        }

        public BuchungDetail(Buchung b)
        {
            InitializeComponent();
            this.b = b;
            binder = new DataBinding.Binder();
            created = false;
        }

        void BindTo()
        {
            binder.BindTo_TextBox(tb_buchungsid, b.Buchungid);
            binder.BindTo_DateTimePicker(dtp_datum, b.Datum);
            binder.BindTo_ComboBox(cb_rechnung, BL.getRechnungen(), b);
            binder.BindTo_ComboBox(cb_kategorie, BL.getBuchungsKategorie(), b);
            binder.BindTo_TextBox(tb_betrag, b.Betrag);
        }

        bool BindFrom()
        {
            binder.StartBindFrom();

            b.Datum = binder.BindFrom_DateTime(dtp_datum, errorControl1, new DataBinding.RequiredRule());
            b.Betrag = binder.BindFrom_Double(tb_betrag, errorControl4, new DataBinding.PositiveRule());
            b.Rechnungid = binder.BindFrom_ComboBox_Int(cb_rechnung, errorControl2, new DataBinding.RequiredRule());
            b.Kategorie = binder.BindFrom_ComboBox_Int(cb_kategorie, errorControl3, new DataBinding.RequiredRule());

            if (created) b.Status = ObjectStates.New;

            if (binder.HasErrors)
                return false;
            return true;
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            if (BindFrom())
            {
                if (b.Status != ObjectStates.Unmodified)
                {
                    BL.saveBuchung(b);
                }
                this.Close();
            }
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuchungDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
