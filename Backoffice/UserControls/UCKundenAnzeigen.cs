﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backoffice.UserControls
{
    public partial class UCKundenAnzeigen : UserControl
    {        
        public UCKundenAnzeigen()
        {
            InitializeComponent();
        }

        void BindTo()
        {
            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_ListView(lv_kunden, BL.getKunden());
        }
        void NewKunde()
        {
            var tmp = new Dialogs.KundeDetail();
            if (tmp.ShowDialog() == DialogResult.OK)
                BindTo();
        }

        void EditKunde(Kunde k)
        {
            var tmp = new Dialogs.KundeDetail(k);
            if (tmp.ShowDialog() == DialogResult.OK)
            {
                BindTo();
            }
        }

        void DeleteKunde(Kunde k)
        {
            BL.deleteKunde(k);
            BindTo();
        }

        private void UCKundenAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void bn_new_Click(object sender, EventArgs e)
        {
            NewKunde();
        }

        private void bn_edit_Click(object sender, EventArgs e)
        {
            if (lv_kunden.SelectedItems.Count == 1)
            {
                EditKunde((Kunde)lv_kunden.FocusedItem.Tag);
            }
        }

        private void bn_delete_Click(object sender, EventArgs e)
        {
            if (lv_kunden.SelectedItems.Count == 1)
            {
                DeleteKunde((Kunde)lv_kunden.FocusedItem.Tag);
            }
        }

        private void lv_kunden_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditKunde((Kunde)lv_kunden.FocusedItem.Tag);
        }

        private void lv_kunden_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void lv_kunden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
