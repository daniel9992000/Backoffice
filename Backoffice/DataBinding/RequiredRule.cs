﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.DataBinding
{
    public class RequiredRule : IRule
    {
        public bool Eval(object value, ErrorControl ctrl)
        {
            if (value is string)
            {
                if (string.IsNullOrWhiteSpace((string)value))
                {
                    ctrl.setError("Das Feld darf nicht leer sein!");
                    return false;
                }
            }
            else
            {
                if (value == null)
                {
                    ctrl.setError("Bitte wählen Sie ein Objekt aus!");
                    return false;
                }
            }

            return true;
        }
    }
}
