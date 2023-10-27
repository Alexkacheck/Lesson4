using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car(); // Создание автомобиля с конструктором по умолчанию
            var Car2 = new Car("Toyota", "Camry", 2020, 2500, 200, 140); // Создание автомобиля с параметрами

            // Доступ к полям автомобиля 2
            Console.WriteLine($"Brand: {Car2.Brand}");
            Console.WriteLine($"Model: {Car2.Model}");
            Console.WriteLine($"Year: {Car2.Year}");
            Console.WriteLine($"Engine Capacity: {Car2.EngineCapacity}");
            Console.WriteLine($"Power: {Car2.Power}");
            Console.WriteLine($"Top Speed: {Car2.TopSpeed}");
        }
    }
}