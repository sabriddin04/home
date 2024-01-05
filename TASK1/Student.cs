class Student:Person
{


  
    public void Study(){
        System.Console.WriteLine("I'm studying");
    }

    public void ShowAge(){
        System.Console.WriteLine($"My age is: {GetAge()} years old");
    }

    public override void SetAge(int age)
    {
        base.SetAge(age);
    }
}