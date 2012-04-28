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
    public partial class UCBuchungenAnzeigen : UserControl
    {
        public UCBuchungenAnzeigen()
        {
            InitializeComponent();
        }

        void BindTo()
        {
            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_ListView(lv_buchungen, BL.getBuchungen());
        }

        private void bn_new_Click(object sender, EventArgs e)
        {

        }

        private void bn_edit_Click(object sender, EventArgs e)
        {

        }

        private void bn_delete_Click(object sender, EventArgs e)
        {

        }

        private void UCBuchungenAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
