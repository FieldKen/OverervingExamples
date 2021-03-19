using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingExamples
{
    class Huis : Gebouw
    {
        public Huis(bool vanSteen) : base(vanSteen)
        {

        }

        public Huis(int aantalVerdiepingen, bool vanSteen) : base(aantalVerdiepingen, vanSteen)
        {

        }
    }
}
