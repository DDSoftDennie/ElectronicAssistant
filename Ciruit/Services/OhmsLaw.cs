using System;
namespace Circuit.Services
{
    public class OhmsLaw
    {
        // V = Voltage
        // I = Current (Amps
        // R = Resistance

        // -3 math statistics = Mili = x 1000

        public OhmsLaw()
        {

        }

        public OhmsLaw(decimal voltage = 0, decimal currrent = 0, decimal resistance = 0)
        {
            Voltage = voltage;
            Current = currrent;
            Resistance = Resistance;
        }

        public decimal Voltage { get; set; }
        public decimal Current { get; set; }
        public decimal Resistance { get; set; }

        public decimal getVolts()
        {
            return (Current * Resistance)/1000;
        }

        public decimal getCurrrent(bool mili = false)
        {
            if (mili == false)
                return (Voltage / Resistance);
            else
                return ((Voltage / Resistance) * 1000);
            
        }

        public decimal getResistance()
        {
            return (Voltage / Current);
        }
    }
}
