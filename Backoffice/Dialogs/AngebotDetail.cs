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
            binder.BindTo_ComboBox(cb_kunde, BL.getKunden(), a);
            cb_projekt.Items.Add(string.Empty);
            binder.BindTo_ComboBox(cb_projekt, BL.getProjekte(), a); 
            binder.BindTo_TextBox(tb_angebotid, a.Angebotid);
            binder.BindTo_TextBox(tb_titel, a.Titel);
            binder.BindTo_TextBox(tb_dauer, a.Dauer);
            binder.BindTo_TextBox(tb_summe, a.Summe);
            binder.BindTo_TextBox(tb_chance, a.Chance);
            binder.BindTo_DateTimePicker(dtp_datum, a.Datum);
        }

        bool BindFrom()
        {
            binder.StartBindFrom();
            a.Titel = binder.BindFrom_String(tb_titel, errorControl1, new DataBinding.RequiredRule());
            a.Dauer = binder.BindFrom_Int(tb_dauer, errorControl2, new DataBinding.PositiveRule());
            a.Chance = binder.BindFrom_Int(tb_chance, errorControl4, new DataBinding.PositiveRule());
            a.Summe = binder.BindFrom_Double(tb_summe, errorControl3, new DataBinding.PositiveRule());
            a.Datum = binder.BindFrom_DateTime(dtp_datum, errorControl7, null);
            a.Kundenid = binder.BindFrom_ComboBox_Int(cb_kunde, errorControl5, new DataBinding.RequiredRule());

            if ((a.Projektid = binder.BindFrom_ComboBox_Int(cb_projekt, errorControl6, null)) == 0)
                a.Projektid = null;

            if (created) a.Status = ObjectStates.New;

            if (binder.HasErrors)
                return false;

            return true;
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            if (BindFrom())
            {
                if (a.Status != ObjectStates.Unmodified)
                { 
                    BL.saveAngebot(a);
                    this.Close();
                }
               
            }
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AngebotDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
