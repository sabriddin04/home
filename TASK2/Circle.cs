class Circle:Shape
{
    int radius;

    public Circle(string color,int radius):base(color)
    {
        this.radius=radius;
    }
    public override string GetInfo()
    {
        return base.GetInfo()+$",radius:{radius}";
    }
}