class Thermostat:Idevice
{ public int  Code;
    public void  TurnOn(){
        System.Console.WriteLine("Thermostat:TurnON");
    }

    public void TurnOff(){
        System.Console.WriteLine("Thermostat:TurnOff");
    }

    public void Price(){
        System.Console.WriteLine($"Code Thermostat:{Code}");
    }
}