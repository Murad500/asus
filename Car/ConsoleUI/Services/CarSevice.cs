using ConsoleUI.Models;

namespace ConsoleUI.Services
{
    public class CarService
    {
        public void Move(Car car, int km )
        {
            decimal finalOil = car.EnginePower * 5;

            decimal kmOil = km * finalOil / 100;

            if (car.CurrentOil > kmOil)
            {
                car.CurrentOil -= kmOil;
                car.Milage += km;
            }
            else
            {
                Console.WriteLine("Kifayet qeder benzin yoxdur");
            }
        }

        public void Ydm(Car car, decimal oil)
        {
            if (car.MaxOil >= oil + car.CurrentOil)
            {
                car.CurrentOil += oil;
            }
            else{
                Console.WriteLine("Hecimden artiq benzin doldurmaq olmaz");
            }
        }
    }
}