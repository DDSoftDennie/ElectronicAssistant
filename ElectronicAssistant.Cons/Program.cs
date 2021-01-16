using System;
using Circuit;

namespace ElectronicAssistant.Cons
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            OhmsLaw ohm = new OhmsLaw();
            
            
            bool more = true;
            Console.WriteLine("Welcome to ElectronicAssistant");
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
            decimal resistance;

            Console.WriteLine("Please enter Current in mA: ");
            decimal.TryParse(Console.ReadLine().ToString(), out current);
            Console.WriteLine("Please enter Resistance in Ohms: ");
            decimal.TryParse(Console.ReadLine().ToString(), out resistance);
            ohm.Current = current;
            ohm.Resistance = resistance;
            Console.WriteLine("Voltage: " + ohm.getVolts());

        }

        public static void GetCurrent()
        {
            OhmsLaw ohm = new OhmsLaw();
            decimal voltage;
            decimal resistance;
            decimal mA;
            Console.WriteLine("Please enter Voltage in Volts: ");
            decimal.TryParse(Console.ReadLine().ToString(), out voltage);
            Console.WriteLine("Please enter Resistance in Ohms: ");
            decimal.TryParse(Console.ReadLine().ToString(), out resistance);
            ohm.Voltage = voltage;
            ohm.Resistance = resistance;
            mA = ohm.getCurrrent() * 1000;
            Console.WriteLine("Current: " + ohm.getCurrrent() + " Amps or " + mA + " mA, mili Amps");

        }

        public static void GetResistance()
        {
            OhmsLaw ohm = new OhmsLaw();
            decimal voltage;
            decimal current;

            Console.WriteLine("Please enter Voltage in Volts: ");
            decimal.TryParse(Console.ReadLine().ToString(), out voltage);
            Console.WriteLine("Please enter Current in Amps: ");
            decimal.TryParse(Console.ReadLine().ToString(), out current);
            ohm.Voltage = voltage;
            ohm.Current = current;
            Console.WriteLine("Voltage: " + ohm.getResistance());

        }
    }
}