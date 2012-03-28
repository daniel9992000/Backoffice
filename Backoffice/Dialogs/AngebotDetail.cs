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
    public partial class AngebotDetail : Form
    {
        Angebot a = null;
        bool created = false;

        public AngebotDetail()
        {
            InitializeComponent();
            this.a = new Angebot();
            this.created = true;
        }

        public AngebotDetail(Angebot a)
        {
            InitializeComponent();
            this.a = a;
        }

        void BindTo()
        {
            foreach (var item in BL.getKunden())
            {
                cb_kunde.Items.Add(item);
                if (item.Kundenid == a.Kundenid)
                    cb_kunde.SelectedItem = item;
            }

            tb_angebotid.Text = a.Angebotid.ToString();
            tb_titel.Text = a.Titel;
            tb_dauer.Text = a.Dauer.ToString();
            tb_summe.Text = a.Summe.ToString();
            tb_chance.Text = a.Chance.ToString();
            dtp_datum.Value = a.Datum;
        }

        bool BindFrom()
        {
            if (tb_titel.Text != "")
            {
                a.Titel = tb_titel.Text;
            }
            else return false;

            int result;
            if (Int32.TryParse(tb_dauer.Text, out result) || tb_dauer.Text == "")
            {
                a.Dauer = result;
            }
            else return false;

            if (Int32.TryParse(tb_chance.Text, out result) || tb_chance.Text == "")
            {
                a.Chance = result;
            }
            else return false;

            double res;
            if (Double.TryParse(tb_summe.Text, out res) || tb_summe.Text == "")
            {
                a.Summe = res;
            }
            else return false;

            a.Datum = dtp_datum.Value;

            a.Kundenid = ((Kunde)cb_kunde.SelectedItem).Kundenid;

            if (created) a.Status = ObjectStates.New;

            return true;
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            if (BindFrom())
            {
                BL.saveAngebot(a);
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void AngebotDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
