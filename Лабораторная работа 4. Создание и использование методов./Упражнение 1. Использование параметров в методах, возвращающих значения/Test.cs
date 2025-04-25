namespace Exm_01
{
    using System;
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            int greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);

        }
    }
}
