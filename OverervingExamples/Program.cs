using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Dier dier = new Dier();
            dier.Eet();
            dier.Adem();

            Paard paard = new Paard();
            paard.Eet();
            paard.Adem();

            paard.KanSpringen = true;


            paard.PasGeboortejaarAan(2011);

            dier.Beschrijf();
            paard.Beschrijf();

            int[] array = new int[5];
            Console.WriteLine(array.ToString());

            Console.WriteLine(dier.ToString());
            Console.WriteLine(paard.ToString());

            Console.ReadLine();
        }
    }
}
