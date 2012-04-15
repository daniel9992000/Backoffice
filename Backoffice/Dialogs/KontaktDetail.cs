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

        public KontaktDetail()
        {
            InitializeComponent();
            k = new Kontakt();
            created = true;
        }

        public KontaktDetail(Kontakt k)
        {
            InitializeComponent();
            this.k = k;
            created = false;
        }

        void BindTo()
        {
            tb_id.Text = k.Kontaktid.ToString();
            tb_firmenname.Text = k.Firmenname;
            tb_vorname.Text = k.Vorname;
            tb_nachname.Text = k.Nachname;
            tb_email.Text = k.Email;
            tb_adresse.Text = k.Adresse;
            tb_hausnummer.Text = k.Hausnummer;
            tb_plz.Text = k.Plz;
            tb_ort.Text = k.Ort;
            tb_telefon.Text = k.Telefon;
            rtb_bemerkungen.Text = k.Bemerkungen;

        }

        bool BindFrom()
        {
            int res1;

            if (!string.IsNullOrWhiteSpace(tb_firmenname.Text))
            {
                k.Firmenname = tb_firmenname.Text;
            }
            else
            {
                return false;
            }

            if (!string.IsNullOrWhiteSpace(tb_vorname.Text))
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
            k.Hausnummer = tb_hausnummer.Text;
            k.Plz = tb_plz.Text;
            k.Ort = tb_ort.Text;
            k.Telefon = tb_telefon.Text;
            k.Bemerkungen = rtb_bemerkungen.Text;

            if (created) k.Status = ObjectStates.New;

            return true;
        }

        void Save()
        {
            if (BindFrom())
            {
                BL.saveKontakt(k);
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

        private void gb3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
