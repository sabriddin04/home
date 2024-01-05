class Person
{

    int age;
    public void Greet(){
        System.Console.WriteLine("HELLO!");
    }

    public virtual  void SetAge(int age){

        this.age=age;
    }
    public int GetAge(){
        return age;
    }
}