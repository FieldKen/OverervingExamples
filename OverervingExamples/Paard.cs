using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingExamples
{
                 //v overerving
    class Paard : Dier
    {
        public bool KanSpringen { get; set; }

        public void PasGeboortejaarAan(int jaar)
        {
            geboortejaar = jaar;
        }

        public override void Beschrijf()
        {
            Console.WriteLine($"Dit is een paard. Het paard is van {geboortejaar}. Kanspringen is {KanSpringen}.");
            //base.Beschrijf();
        }

        public override string ToString()
        {
            return "Dit is een paard (vanuit ToString)";
            //return base.ToString();
        }
    }
}
