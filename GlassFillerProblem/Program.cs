using System;

//  My solution for the glass filling problem described in the instructions found here:
//  https://github.com/dashbored/glass-filler-problem/blob/master/PER12480I-2587-Exempelproblem-Graz-Sweden-AB.pdf
//
//  Each tick of time(changable in the Settings file, default 0.0001 s), 
//  an amount of liquid will be added to the pyramids top glass.
//  If this glass is full, it will split the incoming amount in two
//  and pass down one half on it's left until it finds a non-filled glass,
//  and then it will proceed with the right side.
//
//  Does not work great for larger pyramids if you don't have a lot of time on your hands!

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
