namespace GlassFillerProblem
{
    public class Glass
    {
        public bool IsFull { get; set; } = false;
        public double Capacity { get; set; }
        public double AmountOfLiquid { get; set; }
        public double TimeToFill { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public int RowOfInterest { get; set; }
        public int ColOfInterest { get; set; }
        public Glass[,] Pyramid { get; set; }
        public Glass LowerLeftGlass { get; set; }
        public Glass LowerRightGlass { get; set; }


        public Glass(int row, int col, Glass[,] glassPyramid)
        {
            Init(row, col, glassPyramid);
            RowOfInterest = row;
        }

        public Glass(int row, int col, int rowOfInterest, Glass[,] glassPyramid)
        {
            Init(row, col, glassPyramid);
            RowOfInterest = rowOfInterest;
        }


        void Init(int row, int col, Glass[,] glassPyramid)
        {
            Row = row;
            Col = col;
            Pyramid = glassPyramid;
            Capacity = Settings.Capacity;
            AmountOfLiquid = 0.0;
            IsFull = false;
        }

        public bool FillUp(double massPerTick)
        {
            if (!IsFull)
            {
                AmountOfLiquid += massPerTick;
                IsFull = AmountOfLiquid >= Capacity;

                return IsFull;
            }

            if (Row == RowOfInterest)
            {
                return IsFull;
            }

            InitLowerGlasses();

            LowerLeftGlass.FillUp(massPerTick / 2);
            LowerRightGlass.FillUp(massPerTick / 2);

            return IsFull;

        }

        void InitLowerGlasses()
        {
            if (Pyramid[Row + 1, Col] == null)
            {
                LowerLeftGlass = new Glass(Row + 1, Col, RowOfInterest, Pyramid);
                Pyramid[Row + 1, Col] = LowerLeftGlass;
            }
            else if (LowerLeftGlass == null)
            {
                LowerLeftGlass = Pyramid[Row + 1, Col];
            }

            if (Pyramid[Row + 1, Col + 1] == null)
            {
                LowerRightGlass = new Glass(Row + 1, Col + 1, RowOfInterest, Pyramid);
                Pyramid[Row + 1, Col + 1] = LowerRightGlass;
            }
            else if (LowerRightGlass == null)
            {
                LowerRightGlass = Pyramid[Row + 1, Col + 1];
            }
        }
    }
}
