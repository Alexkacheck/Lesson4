using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    // Класс `Car` представляет автомобиль.
    public partial class Car
    {
        // Закрытые поля

        private string _brand;  // Название бренда автомобиля
        private string _model;  // Модель автомобиля
        private int _year;      // Год выпуска автомобиля
        private int _engineCapacity;  // Объем двигателя автомобиля
        private int _power;     // Мощность двигателя автомобиля
        private int _topSpeed;  // Максимальная скорость автомобиля
        private int _speed;     // Текущая скорость автомобиля

        // Конструкторы

        // Конструктор по умолчанию
        public Car()
        {
            // Задаем значения полей по умолчанию
            _brand = "Unknown";
            _model = "Unknown";
            _year = 0;
            _engineCapacity = 0;
            _power = 0;
            _topSpeed = 0;
        }

        // Конструктор с параметрами
        public Car(string brand, string model, int year, int engineCapacity, int power, int topSpeed)
        {
            // Присваиваем значения полей из параметров
            _brand = brand;
            _model = model;
            _year = year;
            _engineCapacity = engineCapacity;
            _power = power;
            _topSpeed = topSpeed;
        }

        // Методы доступа к закрытым полям

        // Метод доступа к полю `_brand`
        public string Brand
        {
            // Возвращает значение поля `_brand`
            get { return _brand; }

            // Задает новое значение полю `_brand`
            set { _brand = value; }
        }

        public object Model { get; internal set; }
        public object Year { get; internal set; }
        public object EngineCapacity { get; internal set; }
        public object Power { get; internal set; }
        public object TopSpeed { get; internal set; }

        // ...

        // Статические поля

        // Общее количество созданных автомобилей
        public static int TotalCount;

        // Статические методы

        // Увеличивает общее количество созданных автомобилей на единицу
        public static void IncreaseTotalCount()
        {
            // Увеличиваем значение поля `TotalCount` на единицу
            TotalCount++;
        }

        // ...

        // Методы

        // Создает массив из `count` автомобилей
        public static Car[] CreateCars(int count)
        {
            // Создаем массив из `count` автомобилей
            var cars = new Car[count];

            // Заполняем массив автомобилями
            for (int i = 0; i < count; i++)
            {
                cars[i] = new Car();
            }

            // Возвращаем массив
            return cars;
        }

        // ...

        // Дополнительный метод

        // Выводит на консоль список всех созданных автомобилей
        public static void PrintAllCars()
        {
            // Создаем массив из всех созданных автомобилей
            var cars = Car.CreateCars(Car.TotalCount);

            // Проходим по всем автомобилям в массиве
            foreach (var car in cars)
            {
                // Выводим на консоль название бренда автомобиля
                Console.WriteLine(car.Brand);
            }
        }

    }
}
