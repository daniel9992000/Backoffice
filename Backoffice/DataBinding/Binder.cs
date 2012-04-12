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

        public bool HasErrors
        {
            get { return haserrors; }
        }
    }
}
