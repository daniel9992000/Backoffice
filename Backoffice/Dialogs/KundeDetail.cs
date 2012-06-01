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
            binder.BindTo_TextBox(tb_id, k.Kundenid);
            binder.BindTo_TextBox(tb_vorname, k.Vorname);
            binder.BindTo_TextBox(tb_nachname, k.Nachname);
            binder.BindTo_TextBox(tb_email, k.Email);
            binder.BindTo_TextBox(tb_adresse, k.Adresse);
            binder.BindTo_TextBox(tb_hausnr, k.Hausnummer);
            binder.BindTo_TextBox(tb_plz, k.Plz);
            binder.BindTo_TextBox(tb_ort, k.Ort);
            binder.BindTo_TextBox(tb_telefon, k.Telefon);
            binder.BindTo_TextBox(rtb_bemerkungen, k.Bemerkungen);
            binder.BindTo_ListView(lv_angebote, BL.getAngebote(k.Kundenid));
            binder.BindTo_ListView(lv_rechnungen, BL.getAusgaenge(k.Kundenid));
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
                try
                {
                    BL.saveKunde(k);
                    this.Close();
                }
                catch (BLException ex)
                {
                    MessageBox.Show(ex.Message, k.Nachname + " " + k.Vorname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void KundeDetail_Load(object sender, EventArgs e)
        {
            BindTo();
            if (created)
            {
                gb4.Enabled = false;
                gb5.Enabled = false;
            }
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_angebote_DoubleClick(object sender, EventArgs e)
        {           
            Dialogs.AngebotDetail tmp = new AngebotDetail((Angebot)lv_angebote.FocusedItem.Tag);
            tmp.ShowDialog();
            BindTo();
        }

        private void lv_rechnungen_DoubleClick(object sender, EventArgs e)
        {
            Dialogs.RechnungDetail tmp = new RechnungDetail((Ausgang)lv_rechnungen.FocusedItem.Tag);
            tmp.ShowDialog();
            BindTo();
        }

        private void bn_new_angebot_Click(object sender, EventArgs e)
        {
            Dialogs.AngebotDetail tmp = new AngebotDetail();
            tmp.ShowDialog();
            BindTo();
        }

        private void bn_new_rechnung_Click(object sender, EventArgs e)
        {
            Dialogs.RechnungDetail tmp = new RechnungDetail();
            tmp.ShowDialog();
            BindTo();
        }

        private void bn_delete_angebot_Click(object sender, EventArgs e)
        {
            if (lv_angebote.SelectedItems.Count == 1)
            {
                try
                {
                    BL.deleteAngebot((Angebot)lv_angebote.FocusedItem.Tag);
                }
                catch (BLException ex)
                {

                    MessageBox.Show(ex.Message, ((Angebot)lv_angebote.FocusedItem.Tag).Titel, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            BindTo();
        }
    }
}
