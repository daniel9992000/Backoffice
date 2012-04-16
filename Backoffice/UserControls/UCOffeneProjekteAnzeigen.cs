using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backoffice.Dialogs
{
    public partial class UCOffeneProjekteAnzeigen : UserControl
    { 
        List<string> values;
        int anz;
        public UCOffeneProjekteAnzeigen()
        {
            InitializeComponent();
        }

        void BindTo()
        {
            lv_angebote.Items.Clear();
            anz = 0;
            values = new List<string>();
            values.Add("ID:");
            values.Add("Angebotname:");
            values.Add("Chance:");
            values.Add("Summe");
            values.Add("Datum:");
            foreach (var tmp in BL.getOffeneProjekte())
            {
                ListViewItem i = lv_angebote.Items.Add(tmp.Angebotid.ToString());
                i.Tag = tmp;
                i.SubItems.Add(tmp.Titel);
                i.SubItems.Add(tmp.Chance.ToString());
                i.SubItems.Add(tmp.Summe.ToString());
                i.SubItems.Add(tmp.Datum.ToShortDateString());
                values.Add(tmp.Angebotid.ToString());
                values.Add(tmp.Titel);
                values.Add(tmp.Chance.ToString());
                values.Add(tmp.Summe.ToString());
                values.Add(tmp.Datum.ToShortDateString());
                anz++;
            }

            DataBinding.Binder binder = new DataBinding.Binder();
            binder.BindTo_TextBox(tboffprojekte, anz);
        }

        private void UCOffeneProjekteAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void bngenpdf_Click(object sender, EventArgs e)
        {
            CreatePdf mypdf = new CreatePdf();
            mypdf.CreatePdfDocument("OffeneProjekte.pdf");
            mypdf.AddHeader("Offene Projekte laut Angebot");
            mypdf.addTable(5, "Offene Projekte", values);
            mypdf.AddsmallHeader("Anzahl offener Projekte: " + anz);
            mypdf.ClosePdf();
        }

        private void bnakt_Click(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
