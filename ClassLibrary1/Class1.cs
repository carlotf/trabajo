using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        string name;

        public string Name { get => name; set => name = value; }

        public int DevAcotado(String cadena)
        {
            cs_loquito LQ = new cs_loquito();
            return LQ.loquito(cadena);
        }
    }
}
