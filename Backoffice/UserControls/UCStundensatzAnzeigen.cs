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
    public partial class UCStundensatzAnzeigen : UserControl
    {
        List<string> projekte;
        public UCStundensatzAnzeigen()
        {
            InitializeComponent();
        }

        private void UCStundensatzAnzeigen_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void bnakt_Click(object sender, EventArgs e)
        {
            BindTo();
        }

        private void bngen_Click(object sender, EventArgs e)
        {
            CreatePdf mypdf = new CreatePdf();
            mypdf.CreatePdfDocument("Stundesatz_Projekt.pdf");
            mypdf.AddHeader("Stundensatz pro Projekt");
            mypdf.addTable(5, "Projekte", projekte);
            mypdf.AddsmallHeader("Durchschnittlicher Stundensatz: " + tbstdsatz.Text);
            mypdf.ClosePdf();
        }

        void BindTo()
        {
            lv_projekte.Items.Clear();
            projekte = new List<string>();
            double stundensatz, stdsatzges = 0;
            int anz = 0;
            projekte.Add("ID:");
            projekte.Add("Projektname:");
            projekte.Add("Projektdauer:");
            projekte.Add("Projektkosten:");
            projekte.Add("Stundensatz:");
            foreach (var tmp in BL.getProjekte())
            {
                ListViewItem i = lv_projekte.Items.Add(tmp.Projektid.ToString());
                i.Tag = tmp;
                Angebot a = new Angebot();
                a = BL.getAngebot(tmp.Projektid);
                i.SubItems.Add(tmp.Name);
                i.SubItems.Add(a.Dauer.ToString());
                i.SubItems.Add(a.Summe.ToString("#0.00"));
                stundensatz = a.Summe/a.Dauer;
                i.SubItems.Add(stundensatz.ToString("#0.00"));
                projekte.Add(tmp.Projektid.ToString());
                projekte.Add(tmp.Name);
                projekte.Add(a.Dauer.ToString());
                projekte.Add(a.Summe.ToString("#0.00"));
                projekte.Add(stundensatz.ToString("#0.00"));
                anz++;
                stdsatzges+=stundensatz;
            }

            DataBinding.Binder binder = new DataBinding.Binder();
            stdsatzges = stdsatzges /anz;
            binder.BindTo_TextBox(tbstdsatz, stdsatzges.ToString("#0.00"));
          
        }
    }
}
