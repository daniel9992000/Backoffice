using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.DataBinding
{
    public interface IRule
    {
        bool Eval(object value, ErrorControl ctrl);        
    }
}
