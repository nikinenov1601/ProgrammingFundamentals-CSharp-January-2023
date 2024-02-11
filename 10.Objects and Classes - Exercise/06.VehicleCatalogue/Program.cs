using System;
using System.Collections.Generic;
using System.Linq;

class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }

    public override string ToString()
    {
        string capitalizedType = char.ToUpper(Type[0]) + Type.Substring(1);
        return $"Type: {capitalizedType}\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] vehicleInfo = input.Split();
            string type = vehicleInfo[0];
            string model = vehicleInfo[1];
            string color = vehicleInfo[2];
            int horsepower = int.Parse(vehicleInfo[3]);

            Vehicle vehicle = new Vehicle
            {
                Type = type,
                Model = model,
                Color = color,
                Horsepower = horsepower
            };

            vehicles.Add(vehicle);
        }

        List<string> requestedModels = new List<string>();

        while ((input = Console.ReadLine()) != "Close the Catalogue")
        {
            requestedModels.Add(input);
        }

        foreach (var model in requestedModels)
        {
            Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == model);
            if (vehicle != null)
            {
                Console.WriteLine(vehicle);
            }
        }

        double carsHorsepowerSum = 0;
        int carsCount = 0;
        double trucksHorsepowerSum = 0;
        int trucksCount = 0;

        foreach (var vehicle in vehicles)
        {
            if (vehicle.Type == "car")
            {
                carsHorsepowerSum += vehicle.Horsepower;
                carsCount++;
            }
            else if (vehicle.Type == "truck")
            {
                trucksHorsepowerSum += vehicle.Horsepower;
                trucksCount++;
            }
        }

        double averageCarsHorsepower = carsCount > 0 ? carsHorsepowerSum / carsCount : 0;
        double averageTrucksHorsepower = trucksCount > 0 ? trucksHorsepowerSum / trucksCount : 0;

        Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
        Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
    }
}
