using System;
using System.Net.WebSockets;

namespace Завдання_2
{
    //Продаж смартфонів. Визначити ієрархію телефонів.
    //Відсортувати телефони по моделі, виробнику, розміру дисплея.
    //Знайти телефон, який відповідає вказаним параметрам.
    //Підрахувати загальну кількість девайсів на складі.
    //Реалізувати пошук телефону по діапазону цін.

    
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new StoragePhone();
            var operations = new OperationsByPhone(storage);

            var storage2 = new StorageSmartphone();
            var operations2 = new OperationsBySmartphone(storage2);

            var s1 = new Phone("Nokia", "110 DS", 1.77, 999);
            var s2 = new Phone("SIGMA", "Х-treme DT68", 2.4, 1775);
            var s8 = new Phone("ERGO", "B-281", 2.8, 668);

            var s3 = new Smartphone("Apple", "iPhone 14", 6.1, 40999, "iOS", 256, 12, "Yellow");
            var s4 = new Smartphone("Samsung", "Galaxy A54", 6.4, 21999, "Android", 256, 50, "Silver");
            var s5 = new Smartphone("Samsung", "Galaxy A13", 6.6, 6499, "Android", 32, 50, "White");
            var s6 = new Smartphone("Xiaomi", "Redmi Note 10 Pro", 6.7, 9499, "Android", 128, 108, "Onyx Gray");
            var s7 = new Smartphone("OPPO", "A53s", 6.5, 6999, "Android", 128, 50, "Pearl Blue");



            storage.AddPhone(s1);
            storage.AddPhone(s2);
            storage.AddPhone(s8);
            
            storage2.AddSmartphone(s3);
            storage2.AddSmartphone(s4);
            storage2.AddSmartphone(s5);
            storage2.AddSmartphone(s6);
            storage2.AddSmartphone(s7);

            operations.SortPhoneByModel();
            operations2.SortSmartphoneByModel();

            operations.SearchPhone("Nokia", "110 DS", 1.77, 999);
            operations2.SearchPhone("Xiaomi", "Redmi Note 10 Pro", 6.7, 9499, "Android", 128, 108, "Onyx Gray");


            Console.ReadKey();
        }
    }
}