using System;

//  This program tries to solve the problem described here:
//  
//
//
//
//

namespace GlassFillerProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Row?");
            var row = int.Parse(Console.ReadLine());

            Console.WriteLine("Glas?");
            int glass = int.Parse(Console.ReadLine());

            var GlassFiller = new GlassFiller(row, glass);

            GlassFiller.Init();
            GlassFiller.StartFilling();
            GlassFiller.Report();
        }
    }
}
