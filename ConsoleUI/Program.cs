using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());
            var result = carManager.GetCarDetails();

            foreach (var car in result.Data)
            {
                Console.WriteLine("CarName: " + car.CarName);
                Console.WriteLine("BrandName: " + car.BrandName);
                Console.WriteLine("ColorName: " + car.ColorName);
                Console.WriteLine("--------------------");
            }
        }
    }
}