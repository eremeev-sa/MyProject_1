class Triangle : Figure
{
    public double a {get; set;}
    public double b {get; set;}
    public double c {get; set;}

    public Triangle(double A, double B, double C)
    {
        a = A;
        b = B;
        c = C;
    }   

    public override double Calculator()
    {
        double sp = (a + b + c) / 2;   // semiperimetr - половина периметра
        return Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
    }

    public bool rightTriangle(){
        var list = new List<double>{a, b, c};
        list.Sort();
        return Math.Pow(list[0], 2) + Math.Pow(list[1], 2) - Math.Pow(list[2], 2) == 0;
    } 
}