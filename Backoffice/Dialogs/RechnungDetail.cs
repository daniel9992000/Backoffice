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
        Rechnung r = null;
        Rechnungszeile rz = null;
        bool created = false;

        public RechnungDetail()
        {
            InitializeComponent();
            r = new Rechnung();
            created = true;
        }

        public RechnungDetail(Rechnung r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void dtp_datum_ValueChanged(object sender, EventArgs e)
        {

        }

        void BindTo()
        {
            foreach (var item in BL.getProjekte())
            {
                cb_projekt.Items.Add(item);
                if (item.Projektid == r.Projektid)
                    cb_projekt.SelectedItem = item;
            }

            lv_zeilen.Items.Clear();
            foreach (var item in BL.getRechnungszeilen(r.Rechnungid))
            {
                ListViewItem i = lv_zeilen.Items.Add(item.Reid.ToString());
                i.Tag = item;
                i.SubItems.Add(item.Bezeichnung);
                i.SubItems.Add(item.Betrag.ToString() + " Euro");
            }

            if (r.Kundenid != 0)
            {
                if (r.Kundenid.HasValue)
                    tb_kunde.Text = BL.getKunde(r.Kundenid.Value).ToString();
            }
               
            if(r.Rechnungid != 0)
                tb_rechnungid.Text = r.Rechnungid.ToString();

            tb_bezeichnung.Text = r.Bezeichnung;
            dtp_datum.Value = r.Datum.Value;  
        }

        bool BindFrom()
        {
            if (tb_bezeichnung.Text != "")
            {
                r.Bezeichnung = tb_bezeichnung.Text;
            }
            else return false;

            r.Datum = dtp_datum.Value;

            r.Projektid = ((Projekt)cb_projekt.SelectedItem).Projektid;
            r.Kundenid = BL.getProjektAngebot(r.Projektid.Value).Kundenid;

            if (created) r.Status = ObjectStates.New;

            return true;
        }

        bool BindFromZeilen()
        {
            rz = new Rechnungszeile();
            if (tb_rz_bezeichnung.Text != "")
            {
                rz.Bezeichnung = tb_rz_bezeichnung.Text;
            }
            else return false;

            double res;
            if (Double.TryParse(tb_rz_wert.Text, out res))
            {
                rz.Betrag = res;
            }
            else return false;

            rz.Rechnungid = r.Rechnungid;
            rz.Angebotid = BL.getProjektAngebot(r.Projektid.Value).Angebotid;

            rz.Status = ObjectStates.New;

            return true;
        }

        private void RechnungDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            if (BindFrom())
            {
                BL.saveRechnung(r);
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void bn_add_Click(object sender, EventArgs e)
        {
            if (BindFromZeilen())
            {
                BL.saveRechnungszeile(rz);
                BindTo();
            }
        }

        private void lv_zeilen_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Delete)
            {               
                if (lv_zeilen.SelectedItems.Count == 1)
                {
                    BL.deleteRechnungszeile((Rechnungszeile)lv_zeilen.FocusedItem.Tag);
                    BindTo();
                }
            }
        }
    }
}
