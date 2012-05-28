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
    public partial class UCOffeneRechnungenAnzeigen : UserControl
    {
        List<string> ausgangsr;
        List<string> eingangsr;
        public UCOffeneRechnungenAnzeigen()
        {
            InitializeComponent();
        }

        private void UCOffeneRechnungenAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void btnakt_Click(object sender, EventArgs e)
        {
            BindTo();
        }

        private void btngenpdf_Click(object sender, EventArgs e)
        {
            if (sFD1.ShowDialog() == DialogResult.OK)
            {
                CreatePdf mypdf = new CreatePdf();
                mypdf.CreatePdfDocument(sFD1.FileName);
                mypdf.AddHeader("Offene Rechnungen");
                mypdf.addTable(4, "Offene Eingangsrechnungen", eingangsr);
                mypdf.addTable(4, "Offene Ausgangsrechnungen", ausgangsr);
                mypdf.ClosePdf();
            }
        }

        void BindTo()
        {
            lv_eingangr.Items.Clear();
            lv_ausgangr .Items.Clear();
            List<Rechnungszeile> relist = new List<Rechnungszeile>();
            List<Buchung> blist = new List<Buchung>();
            eingangsr = new List<string>();
            ausgangsr = new List<string>();
            double resumme = 0, bsumme = 0;
            eingangsr.Add("ID:");
            eingangsr.Add("Betrag:");
            eingangsr.Add("Offener Betrag:");
            eingangsr.Add("Datum:");
            foreach (var tmp in BL.getoffeneEingangsRechnungen())
            {
                resumme = 0;
                bsumme = 0;
                ListViewItem i = lv_eingangr.Items.Add(tmp.Rechnungid.ToString());
                i.Tag = tmp;                
                resumme = tmp.Betrag;
                blist = BL.getBuchungen(tmp.Rechnungid);
                foreach (var bitem in blist)
                {
                    bsumme += bitem.Betrag;
                }
                bsumme = resumme - bsumme;
                i.SubItems.Add(resumme.ToString("#0.00"));
                i.SubItems.Add(bsumme.ToString("#0.00"));
                i.SubItems.Add(tmp.Datum.Value.ToShortDateString());

                eingangsr.Add(tmp.Rechnungid.ToString());
                eingangsr.Add(resumme.ToString("#0.00"));
                eingangsr.Add(bsumme.ToString("#0.00"));
                eingangsr.Add(tmp.Datum.Value.ToShortDateString());

            }

            ausgangsr.Add("ID:");
            ausgangsr.Add("Betrag gesamt:");
            ausgangsr.Add("Offener Betrag:");
            ausgangsr.Add("Datum:");
            foreach (var tmp in BL.getoffeneAusgangsRechnungen())
            {
                ListViewItem i = lv_ausgangr.Items.Add(tmp.Rechnungid.ToString());
                i.Tag = tmp;

                resumme = BL.getRechnungssumme(tmp.Rechnungid);                
                bsumme = BL.getOffeneSumme(tmp.Rechnungid);

                i.SubItems.Add(resumme.ToString("#0.00"));
                i.SubItems.Add(bsumme.ToString("#0.00"));
                i.SubItems.Add(tmp.Datum.Value.ToShortDateString());

                ausgangsr.Add(tmp.Rechnungid.ToString());
                ausgangsr.Add(resumme.ToString("#0.00"));
                ausgangsr.Add(bsumme.ToString("#0.00"));
                ausgangsr.Add(tmp.Datum.Value.ToShortDateString());
            }
        }
    }
}
