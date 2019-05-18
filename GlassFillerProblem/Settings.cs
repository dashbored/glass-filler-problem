using System;
using System.Collections.Generic;
using System.Text;

namespace GlassFillerProblem
{
    public static class Settings
    {
        public static double Capacity { get; set; } = 10.0;
        public static double MassFlow { get; set; } = 1.0;
        public static double TickRate { get; set; } = 0.0001;
        public static double MassPerTick { get { return MassFlow * TickRate; } }
    }
}
