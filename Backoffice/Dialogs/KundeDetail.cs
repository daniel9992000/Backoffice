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

        public KundeDetail()
        {
            InitializeComponent();
            k = new Kunde();
            created = true;
        }

        public KundeDetail(Kunde k)
        {
            InitializeComponent();
            this.k = k;
            created = false;
        }

        void BindTo()
        {
            tb_id.Text = k.Kundenid.ToString();
            tb_vorname.Text = k.Vorname;
            tb_nachname.Text = k.Nachname;
            tb_email.Text = k.Email;
            tb_adresse.Text = k.Adresse;
            tb_hausnr.Text = k.Hausnummer;

            if (k.Plz == 0)
                tb_plz.Text = "";
            else
                tb_plz.Text = k.Plz.ToString();

            tb_ort.Text = k.Ort;

            if (k.Telefon == 0)
                tb_telefon.Text = "";
            else
                tb_telefon.Text = k.Telefon.ToString();

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
                i.SubItems.Add(item.Datum.ToShortDateString());
            }

        }

        bool BindFrom()
        {
            int res1;

            if (tb_vorname.Text != "")
            {
                k.Vorname = tb_vorname.Text;
            }
            else
            {
                return false;
            }

            if (tb_nachname.Text != "")
            {
                k.Nachname = tb_nachname.Text;
            }
            else return false;

            if (tb_email.Text != "")
                k.Email = tb_email.Text;
            else return false;

            k.Adresse = tb_adresse.Text;
            k.Hausnummer = tb_hausnr.Text;

            if (Int32.TryParse(tb_plz.Text, out res1) || tb_plz.Text == "")
                k.Plz = res1;
            else return false;

            k.Ort = tb_ort.Text;

            decimal result;
            if (Decimal.TryParse(tb_telefon.Text, out result) || tb_telefon.Text == "")
                k.Telefon = result;
            else return false;
               
            k.Bemerkungen = rtb_bemerkungen.Text;

            if (created) k.Status = ObjectStates.New;

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
