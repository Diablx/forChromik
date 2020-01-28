using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8
{
    public class Komputer
    {
        public string Procesor { get; set; }
        public string RAM { get; set; }
        public string HDD { get; set; }
        public string Grafika { get; set; }

        public Komputer(string procesor, string ram, string hdd, string grafika)
        {
            Procesor = procesor;
            RAM = ram;
            HDD = hdd;
            Grafika = grafika;
        }

        public static List<Komputer> Komputers = new List<Komputer>();

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void FillComputersList()
        {
            for (int i = 0; i < 100; i++)
            {
                Komputer komputer = new Komputer(Komputer.RandomString(1), Komputer.RandomString(7), Komputer.RandomString(3), Komputer.RandomString(5));
                Komputer.Komputers.Add(komputer);
            }
        }
    }
}
