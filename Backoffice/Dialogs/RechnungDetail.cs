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

            tb_kunde.Text = BL.getKunde(r.Kundenid).ToString();

            tb_rechnungid.Text = r.Rechnungid.ToString();
            tb_bezeichnung.Text = r.Bezeichnung;
            dtp_datum.Value = r.Datum;            

           
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
            r.Kundenid = BL.getProjektAngebot(r.Projektid).Kundenid;

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
    }
}
