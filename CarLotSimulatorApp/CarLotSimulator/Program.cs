using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            

            
            var danAutoMall = new Car();
            danAutoMall.Make = "Dodge";
            danAutoMall.Model = "Charger";
            danAutoMall.Year = 2022;
            danAutoMall.EngineNoise = "vroom";
            danAutoMall.HonkNoise = "beep";
            danAutoMall.IsDrivable = true;

            lot.Cars.Add(danAutoMall);

            var johnCarSales = new Car()
            {
                Year = 2022,
                Make = "Chevy",
                Model = "Camaro",
                EngineNoise = "vroom",
                HonkNoise = "brump",
                IsDrivable = false
            };

            lot.Cars.Add(johnCarSales);

            var tiffCars = new Car(2013, "Honda", "Civic", "vroom", "beep", true);

            lot.Cars.Add(tiffCars);


            danAutoMall.MakEngineNoise(danAutoMall.EngineNoise);
            johnCarSales.MakeHonkNoise(danAutoMall.HonkNoise);
            tiffCars.MakEngineNoise(tiffCars.EngineNoise);



            

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
