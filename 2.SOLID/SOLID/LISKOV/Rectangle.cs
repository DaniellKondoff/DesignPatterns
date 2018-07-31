namespace SOLID.LISKOV
{
    public class Rectangle
    {
        public virtual int Width { get; set; }

        public virtual int Height { get; set; }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {this.Width}, {nameof(Height)}: {this.Height}";
        }

    }
}
