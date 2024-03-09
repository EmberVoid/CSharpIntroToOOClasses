using System;
using System.Collections.Generic;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic foreach test
            // List<string> planets = new List<string>();
            // planets.AddRange("Mercury,Venus,Earth,Mars,Jupiter,Saturn,Uranus,Neptune,Pluto".Split(','));
            // planets.Sort();

            // foreach (string p in planets)
            // {
            //     Console.WriteLine(p);
            // }

            //More advanced Planets class
            List<Planet> planets = new List<Planet>();
            planets.Add(new Planet("Mercury", 57));
            planets.Add(new Planet("Venus", 108));
            planets.Add(new Planet("Earth", 149));
            planets.Add(new Planet("Mars", 228));
            planets.Add(new Planet("Jupiter", 780));
            planets.Add(new Planet("Saturn", 1437));
            planets.Add(new Planet("Uranus", 2871));
            planets.Add(new Planet("Neptune", 5430));
            planets.Add(new Planet("Pluto", 5900));

            foreach (Planet p in planets)
            {
                Console.WriteLine(p);
            }
        }
    }
}