using System;
using System.Collections.Generic;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planets = new List<string>();
            planets.AddRange("Mercury,Venus,Earth,Mars,Jupiter,Saturn,Uranus,Neptune,Pluto".Split(','));
            planets.Sort();

            foreach (string p in planets)
            {
                Console.WriteLine(p);
            }
        }
    }
}