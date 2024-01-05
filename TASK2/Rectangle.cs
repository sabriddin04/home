class Rectangle:Shape
{
    int length;
    int width;

    public Rectangle( string color,int length,int width):base(color)
    {
        this.length=length;
        this.width=width;
    }

    public override string GetInfo()
    {
        return base.GetInfo()+$",width:{width},length:{length}";
    }


}