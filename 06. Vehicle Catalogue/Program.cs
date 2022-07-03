using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class VehicleCatalogue
    {
        // Type: typeOfVehicle
        // Model: modelOfVehicle  
        // Color: colorOfVehicle
        // Horsepower: horsepowerOfVehicle
        public VehicleCatalogue(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<VehicleCatalogue> vehicleCatalogues = new List<VehicleCatalogue>();
            AddVehicle(vehicleCatalogues);
            PrintModel(vehicleCatalogues);
            PrintHorsePowar(vehicleCatalogues);
        }

       

        static void AddVehicle(List<VehicleCatalogue> vehicleCatalogues)
        {
            //"{typeOfVehicle} {model} {color} {horsepower}"
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] infoVehicle = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = infoVehicle[0];
                string model = infoVehicle[1];
                string color = infoVehicle[2];
                int horsepower = int.Parse(infoVehicle[3]);
                VehicleCatalogue newVehicle = new VehicleCatalogue(type, model, color, horsepower);
                vehicleCatalogues.Add(newVehicle);

                comand = Console.ReadLine();
            }
            return;

        }

        static void PrintModel(List<VehicleCatalogue> vehicleCatalogues)
        {
            string model = Console.ReadLine();
            while (model != "Close the Catalogue")
            {
                VehicleCatalogue modelVehicle = vehicleCatalogues.FirstOrDefault(m => m.Model == model);
                //Type: Car
                //Model: Ferrari
                //Color: red
                //Horsepower: 550
                string type = "";
                if(modelVehicle.Type== "car")
                {
                    type = "Car";
                }
                else
                {
                    type = "Truck";
                }
                Console.WriteLine($"Type: {type}");
                Console.WriteLine($"Model: {modelVehicle.Model}");
                Console.WriteLine($"Color: {modelVehicle.Color}");
                Console.WriteLine($"Horsepower: {modelVehicle.Horsepower}");
                model = Console.ReadLine();

            }
            return;
        }

        private static void PrintHorsePowar(List<VehicleCatalogue> vehicleCatalogues)
        {
            int numbCar = 0;
            int numbTruck = 0;
            int sumHorsPouarCar = 0;
            int sumHorsPouarTtuck = 0;

            foreach (var vehicle in vehicleCatalogues)
            {
                if(vehicle.Type== "car")
                {
                    numbCar++;
                    sumHorsPouarCar += vehicle.Horsepower;
                }
                else
                {
                    numbTruck++;
                    sumHorsPouarTtuck += vehicle.Horsepower;
                }
            }
            //Cars have average horsepower of: 616.67.
            if (numbCar > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {1.0 * sumHorsPouarCar / numbCar:f2}.");

            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            //Trucks have average horsepower of: 333.33.
            if (numbTruck > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {1.0 * sumHorsPouarTtuck / numbTruck:f2}.");

            }
            else
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
