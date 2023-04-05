using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    internal class OperationsByPhone
    {
        private StoragePhone storage;

        public OperationsByPhone(StoragePhone storage) // приймання об'єкта класу Storage в якості параметра
        {
            this.storage = storage;
        }

        public virtual void SortPhoneByCompany() //сортування телефонів за брендом
        {
            var phones = storage.PrintAllPhones();
            phones = phones.OrderBy(p => p.Company).ToList();
            Console.WriteLine("Відсортовані телефони за компанією:");
            PrintPhones(phones);
        }


        public void SortPhoneByModel() //сортування телефонів за моделлю
        {
            var phones = storage.PrintAllPhones();
            phones = phones.OrderBy(p => p.Model).ToList();
            Console.WriteLine("Відсортовані телефони за моделлю:");
            PrintPhones(phones);
        }


        public void SortPhoneByDisplaySize() //сортування телефонів за розміром дисплея
        {
            var phones = storage.PrintAllPhones();
            phones = phones.OrderBy(p => p.DisplaySize).ToList();
            Console.WriteLine("Відсортовані телефони за розміром дисплея:");
            PrintPhones(phones);
        }


        public virtual void SearchPhone(string company, string model, double displaySize, double price) //пошук телефона за параметрами
        {
            var phones = storage.PrintAllPhones();
            var searchResult = phones.Where(p => p.Company == company &&
                                                 p.Model == model &&
                                                 p.DisplaySize == displaySize &&
                                                 p.Price == price);
            if (searchResult.Any())
            {
                Console.WriteLine("Телефони які відповідають введеними вам параметрами:");
                PrintPhones(searchResult.ToList());
            }
            else
            {
                Console.WriteLine("Не знайдено жодного телефона з такими параметрами :(");
            }
        }


        public void SearchPhoneByPriceRange(double minPrise, double maxPrice) //пошук телефона за діапазоном цін
        {
            var phones = storage.PrintAllPhones();
            var searchResult = phones.Where(p => p.Price >= minPrise && p.Price <= maxPrice);
            if (searchResult.Any())
            {
                Console.WriteLine("Знайдені телефони:");
                PrintPhones(searchResult.ToList());
            }
            else
            {
                Console.WriteLine("Не знайдено жодного телефона в такому діапазоні цін :(");
            }
        }


        public virtual void PrintPhones(List<Phone> phones)
        {
            foreach (var phone in phones)
            {
                Console.WriteLine($"Бренд: {phone.Company}");
                Console.WriteLine($"Модель: {phone.Model}");
                Console.WriteLine($"Розмір дисплея: {phone.DisplaySize}Мп");
                Console.WriteLine($"Ціна {phone.Price} грн");
                Console.WriteLine("");
            }
        }
    }

    internal class OperationsBySmartphone
    {
        private StorageSmartphone storage;

        public OperationsBySmartphone(StorageSmartphone storage)
        {
            this.storage = storage;
        }

        public void SortSmartphoneByCompany() //сортування смартфонів за брендом
        {
            var smartphones = storage.PrintAllSmartphones();
            smartphones = smartphones.OrderBy(p => p.Company).ToList();
            Console.WriteLine("Відсортовані смартфони за компанією:");
            PrintSmartphones(smartphones);
        }


        public void SortSmartphoneByModel() //сортування смартфонів за моделлю
        {
            var smartphones = storage.PrintAllSmartphones();
            smartphones = smartphones.OrderBy(p => p.Model).ToList();
            Console.WriteLine("Відсортовані смартфонів за моделлю:");
            PrintSmartphones(smartphones);
        }


        public void SortSmartphoneByDisplaySize() //сортування смартфонів за розміром дисплея
        {
            var smartphones = storage.PrintAllSmartphones();
            smartphones = smartphones.OrderBy(p => p.DisplaySize).ToList();
            Console.WriteLine("Відсортовані смартфонів за розміром дисплея:");
            PrintSmartphones(smartphones);
        }


        public virtual void SearchPhone(string company, string model, double displaySize, double price, 
            string operatingSystem, int memory, double camera, string color) //пошук телефона за параметрами
        {
            var smartphones = storage.PrintAllSmartphones();
            var searchResult = smartphones.Where(p => p.Company == company &&
                                                 p.Model == model &&
                                                 p.DisplaySize == displaySize &&
                                                 p.Price == price &&
                                                 p.OparationSystem == operatingSystem &&
                                                 p.Memory == memory &&
                                                 p.Camera == camera &&
                                                 p.Color == color);
            if (searchResult.Any())
            {
                Console.WriteLine("Смартфони які відповідають введеними вам параметрами:");
                PrintSmartphones(searchResult.ToList());
            }
            else
            {
                Console.WriteLine("Не знайдено жодного смартфона з такими параметрами :(");
            }
        }


        public void PrintSmartphones(List<Smartphone> smartphones)
        {
            foreach (var smartphone in smartphones)
            {
                Console.WriteLine($"Бренд: {smartphone.Company}");
                Console.WriteLine($"Модель: {smartphone.Model}");
                Console.WriteLine($"Розмір дисплея: {smartphone.DisplaySize}''");
                Console.WriteLine($"Ціна {smartphone.Price} грн");
                Console.WriteLine($"Операційна система: {smartphone.OparationSystem}");
                Console.WriteLine($"Об'єм вбудованої пам'яті: {smartphone.Memory} Гб");
                Console.WriteLine($"Камера: {smartphone.Camera} Мп");
                Console.WriteLine($"Колір: {smartphone.Color}");
                Console.WriteLine("");
            }
        }

    }

}
