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
            tb_plz.Text = k.Plz.ToString();
            tb_ort.Text = k.Ort;
            tb_telefon.Text = k.Telefon.ToString();
            rtb_bemerkungen.Text = k.Bemerkungen;
        }

        bool BindFrom()
        {
            if (tb_vorname.Text != "")
            {
                k.Vorname = tb_vorname.Text;
            }
            else return false;

            if (tb_nachname.Text != "")
            {
                k.Nachname = tb_nachname.Text;
            }
            else return false;

            if (created) k.Status = ObjectStates.New;

            return true;
        }

        void Save()
        {
            if (BindFrom())
            {
                BL.saveKunde(k);
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
    }
}
