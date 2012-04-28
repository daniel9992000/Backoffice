using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backoffice.UserControls
{
    public partial class UCProjekteAnzeigen : UserControl
    {
        public UCProjekteAnzeigen()
        {
            InitializeComponent();
        }

        void BindTo()
        {
            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_ListView(lv_projekte, BL.getProjekte());

        }
        void NewProjekt()
        {
            Dialogs.ProjekteDetail tmp = new Dialogs.ProjekteDetail();
            tmp.ShowDialog();
             BindTo();
        }

        void EditProjekt(Projekt p)
        {
            Dialogs.ProjekteDetail tmp = new Dialogs.ProjekteDetail(p);
            tmp.ShowDialog();
            BindTo();            
        }

        void DeleteProjekt(Projekt p)
        {
            BL.deleteProjekt(p);
            BindTo();
        }

        private void lv_projekte_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditProjekt((Projekt)lv_projekte.FocusedItem.Tag);
        }

        private void lv_projekte_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void bn_new_Click_1(object sender, EventArgs e)
        {
            NewProjekt();
        }

        private void bn_edit_Click_1(object sender, EventArgs e)
        {
            if (lv_projekte.SelectedItems.Count == 1)
            {
                EditProjekt((Projekt)lv_projekte.FocusedItem.Tag);
            }
        }

        private void bn_delete_Click_1(object sender, EventArgs e)
        {
            if (lv_projekte.SelectedItems.Count == 1)
            {
                DeleteProjekt((Projekt)lv_projekte.FocusedItem.Tag);
            }
        }

        private void UCProjekteAnzeigen_Load_1(object sender, EventArgs e)
        {
            BindTo();
        }

    }
}
