using System;
using System.Collections.Generic;
namespace Ciruit
{
    public class Resistance
    {
        List<int> Resistors;
        public Resistance()
        {
            Resistors = new List<int>();
        }

        public int Resistor { get; set; }

        public void AddResistorInSeries(int resistance)
        {
            Resistors.Add(resistance);
        }

        public int GetTotalResistance()
        {
            int total = 0;
            foreach (int r in Resistors)
            {
                total += r;
            }
            return total;
        }

    }
}
