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
    public partial class UCJahresumsatzAnzeigen : UserControl
    {
        List<string> values;

        public UCJahresumsatzAnzeigen()
        {
            InitializeComponent();
        }

        private void UCJahresumsatzAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        void BindTo()
        {
            values = new List<string>();
            lv_angebote.Items.Clear();

            DataBinding.Binder binder = new DataBinding.Binder();
            double[] werte = new double[2];
            double faktor;
            werte = BL.getIstJahresumsatz();

            if (DateTime.IsLeapYear(DateTime.Now.Year))
                faktor = 366;
            else
                faktor = 365;

            binder.BindTo_TextBox(tbianzang, double.Parse(werte[0].ToString("#0.00")));
            binder.BindTo_TextBox(tbisumang, double.Parse(werte[1].ToString("#0.00")));

            faktor = faktor / DateTime.Now.DayOfYear;
            werte[0] = werte[0] * faktor;
            werte[1] = werte[1] * faktor;

            binder.BindTo_TextBox(tbanzangebote, double.Parse(werte[0].ToString("#0.00")));
            binder.BindTo_TextBox(tbsumangebote, double.Parse(werte[1].ToString("#0.00")));
            
            values.Add("Angebotname:");
            values.Add("Angebotssumme:");
            values.Add("Datum:");
            values.Add("Chance:");
            foreach (var tmp in BL.getJahresumsatzangebote())
            {
                ListViewItem i = lv_angebote.Items.Add(tmp.Titel);
                i.Tag = tmp;
                i.SubItems.Add(tmp.Summe.ToString());
                i.SubItems.Add(tmp.Datum.ToShortDateString());
                i.SubItems.Add(tmp.Chance.ToString());
                values.Add(tmp.Titel);
                values.Add(tmp.Summe.ToString());
                values.Add(tmp.Datum.ToShortDateString());
                values.Add(tmp.Chance.ToString());
            }

        }

        private void bngenpdf_Click(object sender, EventArgs e)
        {
            CreatePdf mypdf = new CreatePdf();
            mypdf.CreatePdfDocument("Jahresumsatz.pdf");
            mypdf.AddHeader("Prognostizierter Jahresumsatz laut Angebot");
            mypdf.addTable(4, "Angebote", values);
            mypdf.AddsmallHeader("Ist-Stand Angebote:");
            mypdf.AddText("Anzahl Angebote: " + tbianzang.Text);
            mypdf.AddText("Summe Angebote: " + tbisumang.Text);
            mypdf.AddsmallHeader("Prognose für das Jahr " + DateTime.Now.Year+ ":");
            mypdf.AddText("Anzahl Angebote: " + tbanzangebote.Text);
            mypdf.AddText("Summe Angebote: " + tbsumangebote.Text);
            mypdf.ClosePdf();
        }

        private void bnaktualisieren_Click(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
