using System;
using System.Collections.Generic;
using System.Text;

namespace GlassFillerProblem
{
    public class GlassFiller
    {
        public int RowIndexPosition { get; private set; }
        public int ColIndexPosition { get; private set; }
        public Glass[,] Pyramid { get; private set; }
        public double TimeElapsed { get; private set; }
        public Glass TopGlass { get; private set; }
        public Glass GlassOfInterest { get; private set; }
        public int ColPosition { get { return ColIndexPosition + 1; } }
        public int RowPosition { get { return RowIndexPosition + 1; } }


        public GlassFiller(int row, int col)
        {
            RowIndexPosition = row - 1;
            ColIndexPosition = col - 1;
            Pyramid = new Glass[row, row];
            TimeElapsed = 0.0;
            TopGlass = new Glass(0, 0, RowIndexPosition, Pyramid);
            GlassOfInterest = new Glass(RowIndexPosition, ColIndexPosition, Pyramid);
        }

        public void Init()
        {
            Pyramid[0, 0] = TopGlass;
            Pyramid[RowIndexPosition, ColIndexPosition] = GlassOfInterest;
        }

        public void StartFilling()
        {
            while (!GlassOfInterest.IsFull)
            {
                TimeElapsed += Settings.TickRate;
                TopGlass.FillUp(Settings.MassPerTick);
            }
        }

        public void Report()
        {
            Console.WriteLine($"Glass {ColPosition} in row {RowPosition} was filled in {TimeElapsed:00.000} seconds");
        }

    }
}
