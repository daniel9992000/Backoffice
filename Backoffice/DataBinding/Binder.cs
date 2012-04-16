using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

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

        public void BindTo_ListView()
        {
            
        }

        public void BindTo_ComboBox()
        {
            
        }
        #endregion

        public bool HasErrors
        {
            get { return haserrors; }
        }
    }
}
