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
        DataBinding.Binder binder;

        public AngebotDetail()
        {
            InitializeComponent();
            this.a = new Angebot();
            this.created = true;
            binder = new DataBinding.Binder();
        }

        public AngebotDetail(Angebot a)
        {
            InitializeComponent();
            this.a = a;
            binder = new DataBinding.Binder();
        }

        void BindTo()
        {
            foreach (var item in BL.getKunden())
            {
                cb_kunde.Items.Add(item);
                if (item.Kundenid == a.Kundenid)
                    cb_kunde.SelectedItem = item;
            }

            foreach (var item in BL.getProjekte())
            {
                cb_projekt.Items.Add(item);
                if (item.Projektid == a.Projektid)
                    cb_projekt.SelectedItem = item;
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
            binder.StartBindFrom();
            a.Titel = binder.BindFrom_String(tb_titel, errorControl1, new DataBinding.RequiredRule());
            a.Dauer = binder.BindFrom_Int(tb_dauer, errorControl2, new DataBinding.PositiveRule());
            a.Chance = binder.BindFrom_Int(tb_chance, errorControl4, new DataBinding.PositiveRule());
            a.Summe = binder.BindFrom_Double(tb_summe, errorControl3, new DataBinding.PositiveRule());

            a.Datum = dtp_datum.Value;
            a.Kundenid = ((Kunde)binder.BindFrom_ComboBox(cb_kunde, errorControl5, null)).Kundenid;
            a.Projektid = ((Projekt)binder.BindFrom_ComboBox(cb_projekt, errorControl6, null)).Projektid;

            if (created) a.Status = ObjectStates.New;

            if (binder.HasErrors)
                return false;

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
