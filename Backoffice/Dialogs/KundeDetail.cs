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

        public KundeDetail()
        {
            InitializeComponent();
            k = new Kunde();
            this.k.Status = ObjectStates.New;
        }

        public KundeDetail(Kunde k)
        {
            InitializeComponent();
            this.k = k;
            this.k.Status = ObjectStates.Modified;
        }

        void BindTo()
        {
            tb_id.Text = k.Kundenid.ToString();
            tb_vorname.Text = k.Vorname;
            tb_nachname.Text = k.Nachname;
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
