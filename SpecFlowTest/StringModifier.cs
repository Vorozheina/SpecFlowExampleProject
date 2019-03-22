using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTest
{
    public class StringModifier
    {
        public string MainString { get; set; }
        public string Substring { get; set; }

        public string AddSubstringFirst()
        {
            return String.Concat(Substring, MainString);
        }

        public string AddSubstringLast()
        {
            return String.Concat(MainString, Substring);
        }
    }
}

