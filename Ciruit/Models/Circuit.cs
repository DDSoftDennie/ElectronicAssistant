using System;
using System.Collections.Generic;

namespace Circuit.Models
{
    public class Schema
    {
        public Schema()
        {
            Resistors = new List<Resistor>();
        }
        public int ID { get; set; }
        public int Voltage { get; set; }
        public List<Resistor> Resistors { get; set; }

        public int GetTotalResistance()
        {
            int resistance = 0;
            foreach (Resistor r in Resistors)
            {
                resistance += r.Ohm;
            }
            return resistance;
        }
    }

}
