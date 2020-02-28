using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Methods
{
    class ConstVsReadonly
    {
        private readonly string roVariable = "set ReadOnly";
        private const string cVariable = "set Const"; // for Const, you have to set here

        public ConstVsReadonly()
        {
            roVariable = "change ReadOnly";     // for readonly, you can modify in constructor 
            // cVariable = "change const";       // for const, you cannot modify in constructor
        }

        public void tryModifyRead()
        {
            // roVariable = "change ReadOnly";     // for readonly, you cannot modify here
        }
    }
}
