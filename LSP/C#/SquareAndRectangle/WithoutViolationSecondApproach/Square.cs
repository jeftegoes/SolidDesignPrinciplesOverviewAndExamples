namespace WithoutViolationSecondApproach
{
    public class Square : IShape
    {
        public virtual int SideLength { get; set; }

        public Square()
        {

        }

        public Square(int sideLength)
        {
            SideLength = sideLength;
        }

        public int CalculateArea()
        {
            return SideLength * SideLength;
        }

        public override string ToString()
        {
            return $"{nameof(SideLength)}: {SideLength}";
        }
    }
}