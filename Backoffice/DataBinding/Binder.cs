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

        public object BindFrom_ComboBox(ComboBox cb, ErrorControl errctrl, IRule rule)
        {
            cb.BackColor = Color.Empty;
            errctrl.clearError();

            object result = cb.SelectedItem;

            if (result == null)
            {
                haserrors = true;
                cb.BackColor = Color.Red;
                errctrl.setError("Bitte ein Element auswählen");
            }

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
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

        public void BindTo_ListView(ListView lv, List<object> list)
        {
            
        }
        #endregion

        public bool HasErrors
        {
            get { return haserrors; }
        }
    }
}
