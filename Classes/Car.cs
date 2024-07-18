namespace Classes;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    
    public int Year { get; set; }
    
    public void CarMake(){ Console.WriteLine(Make);}
    public void CarModel(){Console.WriteLine(Model);}
    public void CarYear(){Console.WriteLine(Year);}
}