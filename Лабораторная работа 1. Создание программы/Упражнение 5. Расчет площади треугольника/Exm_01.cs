using System;
using System.Xml.Linq;

namespace Exm_05
{
    //-- Программа расчёта площади равностороннего треугольника, периметр которого известен

    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("Please enter Perimetr value");;
            double rPerimetr = Double.Parse( Console.ReadLine() );
            Console.WriteLine("Please enter Storona value");

            double rStorona = Double.Parse( Console.ReadLine() );

            double rS = Math.Sqrt(rPerimetr * (rPerimetr - rStorona) * (rPerimetr - rStorona) * (rPerimetr - rStorona));

            Console.WriteLine("\tSTORONA \t\tPLOSHAD");
            Console.WriteLine("\t  {0:F2} \t\t {1:F2}", rStorona, rS);
        }
    }
}
