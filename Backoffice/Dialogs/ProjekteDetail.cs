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
    public partial class ProjekteDetail : Form
    {
        Projekt p;
        bool created;

        public ProjekteDetail()
        {
            InitializeComponent();
            p = new Projekt();
            created = true;
        }

        public ProjekteDetail(Projekt p)
        {
            InitializeComponent();
            this.p = p;
            created = false;
        }

        void BindTo()
        {
            tb_id.Text = p.Projektid.ToString();
            tb_name.Text = p.Name;
        }

        bool BindFrom()
        {
            if (tb_name.Text != "")
            {
                p.Name = tb_name.Text;
            }
            else return false;

            if (created) p.Status = ObjectStates.New;
            return true;
        }

        void Save()
        {
            if (BindFrom())
            {
                BL.saveProjekt(p);
            }
        }


        private void bn_save_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void ProjekteDetail_Load_1(object sender, EventArgs e)
        {
            BindTo();
        }

    }
}
