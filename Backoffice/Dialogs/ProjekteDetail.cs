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
        DataBinding.Binder binder;

        public ProjekteDetail()
        {
            InitializeComponent();
            p = new Projekt();
            created = true;
            binder = new DataBinding.Binder();
        }

        public ProjekteDetail(Projekt p)
        {
            InitializeComponent();
            this.p = p;
            created = false;
            binder = new DataBinding.Binder();
        }

        void BindTo()
        {
            binder.BindTo_TextBox(tb_id, p.Projektid);
            binder.BindTo_TextBox(tb_name, p.Name);
            binder.BindTo_ListView(lv_angebote, BL.getAngeboteByProjektId(p.Projektid));
            binder.BindTo_ListView(lv_rechungen, BL.getAusgaengeByProjektId(p.Projektid));
            binder.BindTo_ListView(lv_stunden, BL.getStunden(p.Name));
        }

        bool BindFrom()
        {
            binder.StartBindFrom();
            p.Name = binder.BindFrom_String(tb_name, errorControl1, new DataBinding.RequiredRule());

            if (created == true) p.Status = ObjectStates.New;

            if (binder.HasErrors)
                return false;

            return true;
        }

        void Save()
        {
            if (BindFrom())
            {
                if (p.Status != ObjectStates.Unmodified)
                {
                    BL.saveProjekt(p);
                    this.Close();
                }
            }
        }
        
        private void bn_save_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjekteDetail_Load_1(object sender, EventArgs e)
        {
            BindTo();
        }

    }
}
