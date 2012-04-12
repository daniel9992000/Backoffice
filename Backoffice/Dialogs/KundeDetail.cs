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
    public partial class KundeDetail : Form
    {
        Kunde k;
        bool created;
        DataBinding.Binder binder;

        public KundeDetail()
        {
            InitializeComponent();
            k = new Kunde();
            created = true;
            binder = new DataBinding.Binder();
        }

        public KundeDetail(Kunde k)
        {
            InitializeComponent();
            this.k = k;
            created = false;
            binder = new DataBinding.Binder();
        }

        void BindTo()
        {
            tb_id.Text = k.Kundenid.ToString();
            tb_vorname.Text = k.Vorname;
            tb_nachname.Text = k.Nachname;
            tb_email.Text = k.Email;
            tb_adresse.Text = k.Adresse;
            tb_hausnr.Text = k.Hausnummer;

            tb_plz.Text = k.Plz;

            tb_ort.Text = k.Ort;

            tb_telefon.Text = k.Telefon;

            rtb_bemerkungen.Text = k.Bemerkungen;

            lv_angebote.Items.Clear();
            foreach (var item in BL.getKundenAngebote(k.Kundenid))
            {
                ListViewItem i = lv_angebote.Items.Add(item.Angebotid.ToString());
                i.Tag = item;
                i.SubItems.Add(item.Titel);
                i.SubItems.Add(item.Datum.ToShortDateString());
            }

            lv_rechnungen.Items.Clear();
            foreach (var item in BL.getKundenRechnungen(k.Kundenid))
            {
                ListViewItem i = lv_rechnungen.Items.Add(item.Rechnungid.ToString());
                i.Tag = item;
                i.SubItems.Add(item.Bezeichnung);
                i.SubItems.Add(item.Datum.Value.ToShortDateString());
            }

        }

        bool BindFrom()
        {
            binder.StartBindFrom();

            k.Vorname = binder.BindFrom_String(tb_vorname, errorControl1, new DataBinding.RequiredRule());
            k.Nachname = binder.BindFrom_String(tb_nachname, errorControl2, new DataBinding.RequiredRule());            
            k.Email = binder.BindFrom_String(tb_email, errorControl3, new DataBinding.RequiredRule());
            k.Adresse = binder.BindFrom_String(tb_adresse, errorControl4, null);
            k.Hausnummer = binder.BindFrom_String(tb_hausnr, errorControl5, null);
            k.Plz = binder.BindFrom_String(tb_plz, errorControl6, null);
            k.Ort = binder.BindFrom_String(tb_ort, errorControl7, null);
            k.Telefon = binder.BindFrom_String(tb_telefon, errorControl8, null);
            k.Bemerkungen = binder.BindFrom_String(rtb_bemerkungen, errorControl9, null);

            if (created) k.Status = ObjectStates.New;

            if (binder.HasErrors)
                return false;

            return true;
        }

        void Save()
        {
            if (BindFrom())
            {
                BL.saveKunde(k);
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void KundeDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void lv_angebote_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
