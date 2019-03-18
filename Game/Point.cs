namespace Game.Math
{
    public class Point<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}