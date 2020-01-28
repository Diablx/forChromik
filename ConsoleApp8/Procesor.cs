using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8
{
    public class Procesor
    {
        public string Nazwa { get; set; }

        public Procesor(string nazwa)
        {
            Nazwa = nazwa;
        }

        public static List<Procesor> Procesors = new List<Procesor>();
        public static IEnumerable<string> CreateUniqueListOfPorcesors()
        {
            foreach (var item in Komputer.Komputers)
            {
                Procesor procesor = new Procesor(item.Procesor);
                Procesor.Procesors.Add(procesor);
            }
            var uniqueProcesors = Procesor.Procesors.Select(x => x.Nazwa).Distinct().OrderBy(procesor => procesor);
            return uniqueProcesors;
        }

        public static void GetUniquePrcoessors()
        {
            foreach (var item in CreateUniqueListOfPorcesors())
            {
                Console.WriteLine(item);
            }
        }
    }
}
