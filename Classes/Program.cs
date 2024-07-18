namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car buick = new Car() {Make ="GM", Model = "Lacrosse", Year = 2005};
            buick.CarMake();
            buick.CarModel();
            buick.CarYear();
        }
        
    }
}
