class Shape
{ 
    string color;

    public Shape(string color)
    {
        this .color=color;
        
    }

    public virtual string GetInfo(){
        return $"color:{color}";
    }
    

}