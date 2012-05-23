using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace Backoffice.DataBinding
{
    class Binder
    {
        bool haserrors;

        public void StartBindFrom()
        {
            haserrors = false;
        }

        #region BindFrom
        public string BindFrom_String(Control ctrl, ErrorControl errctrl, IRule rule)
        {
            ctrl.BackColor = Color.Empty;
            errctrl.clearError();

            string result = ctrl.Text;

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
                {
                    haserrors = true;
                    ctrl.BackColor = Color.Red;
                }
            }

            return result;
        }

        public int BindFrom_Int(Control ctrl, ErrorControl errctrl, IRule rule)
        {
            ctrl.BackColor = Color.Empty;
            errctrl.clearError();

            int result = 0;
            if (!int.TryParse(ctrl.Text, out result))
            {
                haserrors = true;
                ctrl.BackColor = Color.Red;
                errctrl.setError("Der Wert muss eine Zahl sein!");                
            }

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
                {
                    haserrors = true;
                    ctrl.BackColor = Color.Red;
                }
            }

            return result;
        }

        public double BindFrom_Double(Control ctrl, ErrorControl errctrl, IRule rule)
        {
            ctrl.BackColor = Color.Empty;
            errctrl.clearError();

            double result = 0;
            if (!double.TryParse(ctrl.Text, out result))
            {
                haserrors = true;
                ctrl.BackColor = Color.Red;
                errctrl.setError("Der Wert muss eine Zahl sein!");
            }

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
                {
                    haserrors = true;
                    ctrl.BackColor = Color.Red;
                }
            }

            return result;
        }

        public DateTime BindFrom_DateTime(Control ctrl, ErrorControl errctrl, IRule rule)
        {
            ctrl.BackColor = Color.Empty;
            errctrl.clearError();

            DateTime result = DateTime.Today;

            if (ctrl is DateTimePicker)
            {
                result = ((DateTimePicker)ctrl).Value;
            }           

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
                {
                    haserrors = true;
                    ctrl.BackColor = Color.Red;
                }
            }

            return result;
        }

        public int BindFrom_ComboBox_Int(ComboBox cb, ErrorControl errctrl, IRule rule)
        {
            cb.BackColor = Color.Empty;
            errctrl.clearError();

            int result = 0;
            object selected = cb.SelectedItem;

            if (selected != null)
            {
                if (selected is Kunde)
                {
                    result = ((Kunde)selected).Kundenid;
                }
                else if (selected is Projekt)
                {
                    result = ((Projekt)selected).Projektid;
                }
                else if (selected is Kontakt)
                {
                    result = ((Kontakt)selected).Kontaktid;
                }
                else if (selected is Rechnung)
                {
                    result = ((Rechnung)selected).Rechnungid;
                }
                else if (selected is Buchungskategorie)
                {
                    result = ((Buchungskategorie)selected).Bkatid;
                }
            }

            if (rule != null)
            {
                if (!rule.Eval(selected, errctrl))
                {
                    haserrors = true;
                    cb.BackColor = Color.Red;
                }
            }

            return result;
        }
        #endregion

        #region BindTo
        public void BindTo_TextBox(Control ctrl, object value)
        {
            if (value != null)
            {
                ctrl.Text = value.ToString();
            }
            
        }

        public void BindTo_DateTimePicker(DateTimePicker ctrl, object value)
        {
            if (value != null)
            {
                ctrl.Value = (DateTime)value;
            }

        }

        public void BindTo_ListView(ListView lv, IList values)
        {
            lv.Items.Clear();
            lv.Columns.Clear();
            lv.GridLines = true;
            lv.FullRowSelect = true;
            lv.View = View.Details;

            if (typeof(IList<Angebot>).IsInstanceOfType(values))
            {
                lv.Columns.Add("ID", 25);
                lv.Columns.Add("Titel", 120);
                lv.Columns.Add("Datum", 80);
                lv.Columns.Add("Dauer", 40);
                lv.Columns.Add("Summe", 110, HorizontalAlignment.Right);
                lv.Columns.Add("Chance", 40);

                foreach (var item in values)
                {
                    var tmp = (Angebot)item;

                    ListViewItem i = lv.Items.Add(tmp.Angebotid.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Titel);
                    i.SubItems.Add(tmp.Datum.ToShortDateString());
                    i.SubItems.Add(tmp.Dauer.ToString());
                    i.SubItems.Add(tmp.Summe.ToString("#0.00") + " Euro");
                    i.SubItems.Add(tmp.Chance.ToString() + "%");
                }
            }
            else if (typeof(IList<Ausgang>).IsInstanceOfType(values))
            {
                lv.Columns.Add("ID", 25);
                lv.Columns.Add("Bezeichnung", 120);
                lv.Columns.Add("Datum", 80);

                foreach (var item in values)
                {
                    var tmp = (Ausgang)item;

                    ListViewItem i = lv.Items.Add(tmp.Rechnungid.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Bezeichnung);
                    i.SubItems.Add(tmp.Datum.Value.ToShortDateString());
                }
            }
            else if (typeof(IList<Kunde>).IsInstanceOfType(values))
            {
                lv.Columns.Add("ID", 25);
                lv.Columns.Add("Nachname", 100);
                lv.Columns.Add("Vorname", 100);
                lv.Columns.Add("Email", 160);
                lv.Columns.Add("Adresse", 120);
                lv.Columns.Add("Hausnummer", 60);
                lv.Columns.Add("PLZ", 40);
                lv.Columns.Add("Ort", 130);

                foreach (var item in values)
                {
                    var tmp = (Kunde)item;

                    ListViewItem i = lv.Items.Add(tmp.Kundenid.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Nachname);
                    i.SubItems.Add(tmp.Vorname);
                    i.SubItems.Add(tmp.Email);
                    i.SubItems.Add(tmp.Adresse);
                    i.SubItems.Add(tmp.Hausnummer);
                    i.SubItems.Add(tmp.Plz);
                    i.SubItems.Add(tmp.Ort);
                }
            }
            else if (typeof(IList<Kontakt>).IsInstanceOfType(values))
            {
                lv.Columns.Add("ID", 25);
                lv.Columns.Add("Nachname", 100);
                lv.Columns.Add("Vorname", 100);
                lv.Columns.Add("Firmenname", 100);
                lv.Columns.Add("Email", 160);
                lv.Columns.Add("Adresse", 120);
                lv.Columns.Add("Hausnummer", 60);
                lv.Columns.Add("PLZ", 40);
                lv.Columns.Add("Ort", 130);

                foreach (var item in values)
                {
                    var tmp = (Kontakt)item;

                    ListViewItem i = lv.Items.Add(tmp.Kontaktid.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Nachname);
                    i.SubItems.Add(tmp.Vorname);
                    i.SubItems.Add(tmp.Firmenname);
                    i.SubItems.Add(tmp.Email);
                    i.SubItems.Add(tmp.Adresse);
                    i.SubItems.Add(tmp.Hausnummer);
                    i.SubItems.Add(tmp.Plz);
                    i.SubItems.Add(tmp.Ort);
                }
            }
            else if (typeof(IList<Eingang>).IsInstanceOfType(values))
            {
                lv.Columns.Add("ID", 25);
                lv.Columns.Add("Bezeichnung", 120);
                lv.Columns.Add("Datum", 80);
                lv.Columns.Add("Betrag", 110, HorizontalAlignment.Right);

                foreach (var item in values)
                {
                    var tmp = (Eingang)item;

                    ListViewItem i = lv.Items.Add(tmp.Rechnungid.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Bezeichnung);
                    i.SubItems.Add(tmp.Datum.Value.ToShortDateString());
                    i.SubItems.Add(tmp.Betrag.ToString("#0.00") + " Euro");
                }
            }
            else if (typeof(IList<Ausgang>).IsInstanceOfType(values))
            {
                lv.Columns.Add("ID", 25);
                lv.Columns.Add("Bezeichnung", 120);
                lv.Columns.Add("Datum", 80);

                foreach (var item in values)
                {
                    var tmp = (Ausgang)item;

                    ListViewItem i = lv.Items.Add(tmp.Rechnungid.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Bezeichnung);
                    i.SubItems.Add(tmp.Datum.Value.ToShortDateString());
                }
            }
            else if (typeof(IList<Rechnungszeile>).IsInstanceOfType(values))
            {
                lv.Columns.Add("ID", 25);
                lv.Columns.Add("Bezeichnung", 120);
                lv.Columns.Add("Betrag", 110, HorizontalAlignment.Right);

                foreach (var item in values)
                {
                    var tmp = (Rechnungszeile)item;

                    ListViewItem i = lv.Items.Add(tmp.Reid.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Bezeichnung);
                    i.SubItems.Add(tmp.Betrag.ToString("#0.00") + " Euro");
                }
            }
            else if (typeof(IList<Buchung>).IsInstanceOfType(values))
            {
                lv.Columns.Add("ID", 25);
                lv.Columns.Add("Datum", 120);
                lv.Columns.Add("Betrag", 110, HorizontalAlignment.Right);
                lv.Columns.Add("Rechnung", 140);
                lv.Columns.Add("Kategorie", 100);

                foreach (var item in values)
                {
                    var tmp = (Buchung)item;

                    ListViewItem i = lv.Items.Add(tmp.Buchungid.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Datum.ToShortDateString());
                    i.SubItems.Add(tmp.Betrag.ToString("#0.00") + " Euro");
                    i.SubItems.Add(BL.getRechnung(tmp.Rechnungid).Bezeichnung);
                    i.SubItems.Add(BL.getBuchungsKategorie(tmp.Kategorie).Bezeichung);
                }
            }
            else if (typeof(IList<Projekt>).IsInstanceOfType(values))
            {
                lv.Columns.Add("ID", 25);
                lv.Columns.Add("Name", 150);
                lv.Columns.Add("Stunden", 100);

                foreach (var item in values)
                {
                    var tmp = (Projekt)item;

                    ListViewItem i = lv.Items.Add(tmp.Projektid.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Name);
                    i.SubItems.Add(tmp.Stunden.ToString());

                   
                }
            }
            else if (typeof(IList<Stunden>).IsInstanceOfType(values))
            {
                lv.Columns.Add("Name", 100);
                lv.Columns.Add("Mitarbeiter", 100);
                lv.Columns.Add("Stunden", 60);
                lv.Columns.Add("Datum", 100);

                foreach (var item in values)
                {
                    var tmp = (Stunden)item;

                    ListViewItem i = lv.Items.Add(tmp.Projektname);
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Mitarbeiter);
                    i.SubItems.Add(tmp.Stundenanz.ToString());
                    i.SubItems.Add(tmp.Datum.ToShortDateString());                   
                }
            }
        }

        public void BindTo_ComboBox(ComboBox cb, IList values, object o)
        {
            cb.Items.Clear();

            if (typeof(IList<Kunde>).IsInstanceOfType(values))
            {
                foreach (var item in values)
                {
                    cb.Items.Add(item);
                    if (o is Angebot)
                    {
                        if (((Kunde)item).Kundenid == ((Angebot)o).Kundenid)
                        {
                            cb.SelectedItem = item;
                        }
                    }
                }
            }
            else if (typeof(IList<Projekt>).IsInstanceOfType(values))
            {
                foreach (var item in values)
                {
                    cb.Items.Add(item);
                    if (o is Angebot)
                    {
                        if (((Projekt)item).Projektid == ((Angebot)o).Projektid)
                        {
                            cb.SelectedItem = item;
                        }
                    }
                    else if (o is Ausgang)
                    {
                        if (((Projekt)item).Projektid == ((Ausgang)o).Projektid)
                        {
                            cb.SelectedItem = item;
                        }
                    }
                }
            }
            else if (typeof(IList<Kontakt>).IsInstanceOfType(values))
            {
                foreach (var item in values)
                {
                    cb.Items.Add(item);
                    if (o is Eingang)
                    {
                        if (((Kontakt)item).Kontaktid == ((Eingang)o).Kontaktid)
                        {
                            cb.SelectedItem = item;
                        }
                    }
                }
            }
            else if (typeof(IList<Rechnung>).IsInstanceOfType(values))
            {
                foreach (var item in values)
                {
                    cb.Items.Add(item);
                    if (o is Buchung)
                    {
                        if (((Rechnung)item).Rechnungid == ((Buchung)o).Rechnungid)
                        {
                            cb.SelectedItem = item;
                        }
                    }
                }
            }
            else if (typeof(IList<Buchungskategorie>).IsInstanceOfType(values))
            {
                foreach (var item in values)
                {
                    cb.Items.Add(item);
                    if (o is Buchung)
                    {
                        if (((Buchungskategorie)item).Bkatid == ((Buchung)o).Kategorie)
                        {
                            cb.SelectedItem = item;
                        }
                    }
                }
            }
        }
        #endregion

        public bool HasErrors
        {
            get { return haserrors; }
        }
    }
}
