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
    public partial class UCEingangAnzeigen : UserControl
    {
        public UCEingangAnzeigen()
        {
            InitializeComponent();
        }

        void BindTo()
        {
            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_ListView(lv_eingang, BL.getEingaenge());           
        }

        void BindTo(string search)
        {
            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_ListView(lv_eingang, BL.getEingaenge(search));
        }

        private void UCEingangAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        void EditRechnung(Eingang r)
        {
            Dialogs.EingangDetail tmp = new Dialogs.EingangDetail(r);
            tmp.ShowDialog();
            BindTo();
        }

        void NewRechnung()
        {
            Dialogs.EingangDetail tmp = new Dialogs.EingangDetail();
            tmp.ShowDialog();
            BindTo();
        }

        void DeleteRechnung(Eingang r)
        {
            BL.deleteEingang(r);
            BindTo();

        }
        private void bnnew_Click(object sender, EventArgs e)
        {
            NewRechnung();
        }

        private void bnedit_Click(object sender, EventArgs e)
        {
            if (lv_eingang.SelectedItems.Count == 1)
            {
                EditRechnung((Eingang)lv_eingang.FocusedItem.Tag);
            }
        }

        private void bndel_Click(object sender, EventArgs e)
        {
            if (lv_eingang.SelectedItems.Count == 1)
            {
                DeleteRechnung((Eingang)lv_eingang.FocusedItem.Tag);
            }
        }

        private void lv_eingang_DoubleClick(object sender, EventArgs e)
        {
            EditRechnung((Eingang)lv_eingang.FocusedItem.Tag);
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            BindTo(tb_search.Text);
        }
    }
}
