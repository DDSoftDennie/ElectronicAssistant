using System;
using Circuit.Models;
using Circuit.Services;


namespace ElectronicAssistant.Cons
{
    class MainClass
    {
        public static Schema schema;

        public static void Main(string[] args)
        {
            OhmsLaw ohm = new OhmsLaw();

            schema = new Schema();
            Resistor r1 = new Resistor("R1", 220, "");
            Resistor r2 = new Resistor("R2", 330, "");

            schema.Voltage = 5;
            schema.Resistors.Add(r1);
            schema.Resistors.Add(r2);


            
            bool more = true;
            Console.WriteLine("Welcome to ElectronicAssistant");

            Console.WriteLine("Resistance of Schema = " + schema.GetTotalResistance());
            do
            {
                Console.WriteLine("What do you want to calucalte: Volts (V), Current (I) or Resistance (R)?");
                string key = Console.ReadLine().ToString();
                switch (key)
                {
                    case "v":
                        {
                            GetVoltage();
                            break;
                        }
                    case "i":
                        {
                            GetCurrent();
                            break;
                        }
                    case "r":
                        {
                            GetResistance();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                Console.WriteLine("Do you want do to count more?");
                more = Console.ReadKey().Key == ConsoleKey.Y ? true : false;

            } while (more == true);
            
        }

        public static void GetVoltage()
        {
            OhmsLaw ohm = new OhmsLaw();
            decimal current;
            Console.WriteLine("Please enter Current in mA: ");
            decimal.TryParse(Console.ReadLine().ToString(), out current);
          
            ohm.Current = current;
            ohm.Resistance = (decimal) schema.GetTotalResistance();
            Console.WriteLine("Voltage: " + ohm.getVolts());

        }

        public static void GetCurrent()
        {
            OhmsLaw ohm = new OhmsLaw();
            decimal mA;
            ohm.Voltage = (decimal) schema.Voltage ;
            ohm.Resistance = (decimal) schema.GetTotalResistance();
            mA = ohm.getCurrrent() * 1000;
            Console.WriteLine("Current: " + ohm.getCurrrent() + " Amps or " + mA + " mA, mili Amps");

        }

        public static void GetResistance()
        {
            OhmsLaw ohm = new OhmsLaw();
            decimal voltage;
            decimal current;

            voltage = schema.Voltage;
            Console.WriteLine("Please enter Current in Amps: ");
            decimal.TryParse(Console.ReadLine().ToString(), out current);
            ohm.Voltage = voltage;
            ohm.Current = current;
            Console.WriteLine("Resistance: " + ohm.getResistance()*1000);

        }
    }
}