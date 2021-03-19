using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingExamples
{
    class Dier : Levend
    {
        protected int geboortejaar;
        public void Eet()
        {
            Console.WriteLine("Er wordt gegeten");
        }

        public override void Beschrijf()
        {
            Console.WriteLine($"Dit is een dier. Het dier zijn geboortejaar is {geboortejaar}.");
        }
    }
}
