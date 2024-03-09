using System;

namespace Foreach
{
    class Planet
    {
        protected int ScaleFactor = 30;
        public string Name { get; set; }
        public int DistanceFromSun { get; set; }

        public Planet(string name)
        {
            Name = name;
        }

        public Planet(string name, int distance)
        {
            Name = name;
            DistanceFromSun = distance;
        }

        public override string ToString()
        {
            return $"{Name} is {DistanceFromSun} millions of kms from the sun";
        }

        public void Print(Planet previousPlanet)
        {
            int d = previousPlanet != null ? (DistanceFromSun - previousPlanet.DistanceFromSun) / ScaleFactor : 0;
            for (int i = 0; i < d; i++)
            {
                Console.Write(" ");
            }
            Console.Write(Name);
        }
    }
}