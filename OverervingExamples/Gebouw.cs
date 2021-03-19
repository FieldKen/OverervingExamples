using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingExamples
{
    class Gebouw
    {
        public int AantalVerdiepingen { get; private set; }
        public bool VanSteen { get; private set; }

        public Gebouw(bool vanSteen)
        {
            AantalVerdiepingen = 1;
            VanSteen = vanSteen;
        }

        public Gebouw(int aantalVerdiepingen, bool vanSteen)
        {
            AantalVerdiepingen = aantalVerdiepingen;
            VanSteen = vanSteen;
        }
    }
}
