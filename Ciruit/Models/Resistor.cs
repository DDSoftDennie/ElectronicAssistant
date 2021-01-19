using System;
namespace Circuit.Models
{
    public class Resistor
    {
        public Resistor(string id, int ohm, string colorCode)
        {
            this.ID = id;
            this.Ohm = ohm;
            this.ColorCode = colorCode;
        }
        public string ID { get; set; } // R1, R2, ...
        public int Ohm { get; set; }
        public string ColorCode { get; set; }

    }
}
