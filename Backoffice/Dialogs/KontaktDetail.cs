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
        }

        bool BindFrom()
        {
            if (tb_firmenname.Text != "")
            {
                k.Firmenname = tb_firmenname.Text;
            }
            else return false;
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
    }
}
