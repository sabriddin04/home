class Lamp:Idevice
{ public int  price;
    public void  TurnOn(){
        System.Console.WriteLine("Lamp:TurnON");
    }

    public void TurnOff(){
        System.Console.WriteLine("Lamp:TurnOff");
    }

    public void Price(){
        System.Console.WriteLine($"PRICE LAMP:{price}");
    }
}