internal class Program
{
    abstract class Figure
    {
        public string color;
        public double x;
        public double y;
        public double l;
        public double a;
        public Figure(string c, double x, double y, double l, double a)
        {
            this.x=x; this.color=c; this.x=x; this.y=y; this.l=l; this.a=a;
        }
        public abstract void Draw();
        public abstract void Area();
    }
        class circle : Figure
    {
        public double diameter {get;set;}
        public circle(string c, double x, double y, double l, double a, double d): base(c,x,y,l,a)
        {diameter=d;}
        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle");
        }
                public override void Area()
        {
            return Math.PI*Math.Pow(diameter/2.0,2);
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}