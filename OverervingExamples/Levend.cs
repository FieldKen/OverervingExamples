using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingExamples
{
    class Levend : System.Object
    {
        public void Adem()
        {
            Console.WriteLine("Er wordt geademd");
        }

        public virtual void Beschrijf()
        {
            Console.WriteLine("Dit is een levend organisme.");
        }

        public override string ToString()
        {
            return "Levend!";
        }
    }
}
