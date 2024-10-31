class Circle : Figure
{
    public double radius{get; set;}
    public Circle(double Radius)
    {
        radius = Radius;
    }

    public override double Calculator()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}