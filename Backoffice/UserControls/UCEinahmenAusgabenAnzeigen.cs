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
    public partial class UCEinahmenAusgabenAnzeigen : UserControl
    {
        List<string> einnahmen;
        List<string> ausgaben;
        public UCEinahmenAusgabenAnzeigen()
        {
            InitializeComponent();
        }

     

        private void UCEinahmenAusgabenAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        void BindTo()
        {
            lv_einnahmen.Items.Clear();
            lv_ausgaben.Items.Clear();
            List<Rechnungszeile> relist = new List<Rechnungszeile>();
            einnahmen = new List<string>();
            ausgaben = new List<string>();
            double resumme = 0;
            einnahmen.Add("ID:");
            einnahmen.Add("Betrag:");
            einnahmen.Add("Kategorie:");
            einnahmen.Add("Datum:");
            foreach (var tmp in BL.getMonatsEinnahmen(dtp1.Value.Month, dtp1.Value.Year))
            {
                ListViewItem i = lv_einnahmen.Items.Add(tmp.Rechnungid.ToString());
                i.Tag = tmp;
                relist = BL.getRechnungszeilen(tmp.Rechnungid);
                foreach( var item in relist)
                {
                    resumme+= item.Betrag;
                }
                i.SubItems.Add(resumme.ToString("#0.00"));
                i.SubItems.Add(tmp.Bezeichnung);
                i.SubItems.Add(tmp.Datum.Value.ToShortDateString());
                einnahmen.Add(tmp.Rechnungid.ToString());
                einnahmen.Add(resumme.ToString("#0.00"));
                einnahmen.Add(tmp.Bezeichnung.ToString());
                einnahmen.Add(tmp.Datum.Value.ToShortDateString());
                
            }

            ausgaben.Add("ID:");
            ausgaben.Add("Betrag:");
            ausgaben.Add("Kategorie:");
            ausgaben.Add("Datum:");
            foreach (var tmp in BL.getMonatsAusgaben(dtp1.Value.Month, dtp1.Value.Year))
            {
                ListViewItem i = lv_ausgaben.Items.Add(tmp.Rechnungid.ToString());
                i.Tag = tmp;
                relist = BL.getRechnungszeilen(tmp.Rechnungid);
                foreach (var item in relist)
                {
                    resumme += item.Betrag;
                }
                i.SubItems.Add(resumme.ToString("#0.00"));
                i.SubItems.Add(tmp.Bezeichnung);
                i.SubItems.Add(tmp.Datum.Value.ToShortDateString());
                ausgaben.Add(tmp.Rechnungid.ToString());
                ausgaben.Add(resumme.ToString("#0.00"));
                ausgaben.Add(tmp.Bezeichnung.ToString());
                ausgaben.Add(tmp.Datum.Value.ToShortDateString());
            }
        }

        private void bn_createpdf_Click(object sender, EventArgs e)
        {
            CreatePdf mypdf = new CreatePdf();
            mypdf.CreatePdfDocument("Monatsbericht.pdf");
            mypdf.AddHeader("Einnahmen und Ausgaben: "+ dtp1.Value.ToString("MMMM") + " " + dtp1.Value.Year);
            mypdf.addTable(4, "Einnahmen", einnahmen);
            mypdf.addTable(4, "Ausgaben", ausgaben);
            mypdf.ClosePdf();
        }

        private void bnaktualisieren_Click(object sender, EventArgs e)
        {
            BindTo();
        }

    }
}
