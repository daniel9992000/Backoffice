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
    public partial class KontaktDetail : Form
    {
        Kontakt k;
        bool created;
        DataBinding.Binder binder;

        public KontaktDetail()
        {
            InitializeComponent();
            k = new Kontakt();
            created = true;
            binder = new DataBinding.Binder();
        }

        public KontaktDetail(Kontakt k)
        {
            InitializeComponent();
            this.k = k;
            created = false;
            binder = new DataBinding.Binder();
        }

        void BindTo()
        {
            binder.BindTo_TextBox(tb_id, k.Kontaktid);
            binder.BindTo_TextBox(tb_firmenname, k.Firmenname);
            binder.BindTo_TextBox(tb_vorname, k.Vorname);
            binder.BindTo_TextBox(tb_nachname, k.Nachname);
            binder.BindTo_TextBox(tb_email, k.Email);
            binder.BindTo_TextBox(tb_adresse, k.Adresse);
            binder.BindTo_TextBox(tb_hausnummer, k.Hausnummer);
            binder.BindTo_TextBox(tb_plz, k.Plz);
            binder.BindTo_TextBox(tb_ort, k.Ort);
            binder.BindTo_TextBox(tb_telefon, k.Telefon);
            binder.BindTo_TextBox(rtb_bemerkungen, k.Bemerkungen);
            binder.BindTo_ListView(lv_eingang, BL.getEingaenge(k.Kontaktid));
        }

        bool BindFrom()
        {
            binder.StartBindFrom();
            k.Firmenname = binder.BindFrom_String(tb_firmenname, errorControl1, new DataBinding.RequiredRule());
            k.Vorname = binder.BindFrom_String(tb_vorname, errorControl2, new DataBinding.RequiredRule());
            k.Nachname = binder.BindFrom_String(tb_nachname, errorControl3, new DataBinding.RequiredRule());
            k.Email = binder.BindFrom_String(tb_email, errorControl4, new DataBinding.RequiredRule());
            k.Adresse = binder.BindFrom_String(tb_adresse, errorControl5, null);
            k.Hausnummer = binder.BindFrom_String(tb_hausnummer, errorControl6, null);
            k.Plz = binder.BindFrom_String(tb_plz, errorControl7, null);
            k.Ort = binder.BindFrom_String(tb_ort, errorControl8, null);
            k.Telefon = binder.BindFrom_String(tb_telefon, errorControl9, null);
            k.Bemerkungen = binder.BindFrom_String(rtb_bemerkungen, errorControl10, null);

            if (created) k.Status = ObjectStates.New;

            if (binder.HasErrors)
                return false;

            return true;
        }

        void Save()
        {
            if (BindFrom())
            {
                if (k.Status != ObjectStates.Unmodified)
                {
                    BL.saveKontakt(k);
                    this.Close();
                }
            }
        }
        private void KontaktDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void bnsave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void lv_eingang_DoubleClick(object sender, EventArgs e)
        {
            Dialogs.EingangDetail tmp = new EingangDetail((Eingang)lv_eingang.FocusedItem.Tag);
            tmp.ShowDialog();
            BindTo();
        }

        private void bncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bn_new_rechnung_Click(object sender, EventArgs e)
        {
            Dialogs.EingangDetail tmp = new EingangDetail();
            tmp.ShowDialog();
            BindTo();
        }
    }
}
