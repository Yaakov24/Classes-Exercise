namespace Classes
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Lambo";
            car1.Model = "new";
            car1.Year = "2024";
            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.Year);

            Car car2 = new Car();
            car2.Make = "Jalopy";
            car2.Model = "old";
            car2.Year = "1930";
            Console.WriteLine(car2.Make);
            Console.WriteLine(car2.Model);
            Console.WriteLine(car2.Year);


            
        }
    }
}
