using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    internal class Phone
    {
        private string company;
        private string model;
        private double displaySize;
        private double price;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double DisplaySize
        {
            get { return displaySize; }
            set { displaySize = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Phone(string company, string model, double displaySize, double price)
        {
            this.company = company;
            this.model = model;
            this.displaySize = displaySize;
            this.price = price;
        }
    }
    class Smartphone : Phone
    {
        private string operatingSystem;
        private int memory;
        private double camera;
        private string color;

        public string OparationSystem
        {
            get { return operatingSystem; }
            set { operatingSystem = value; }
        }

        public int Memory
        {
            get { return memory; }
            set { memory = value; }
        }

        public double Camera
        {
            get { return camera; }
            set { camera = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Smartphone(string company, string model, double displaySize, double price,
            string operatingSystem, int memory, double camera, string color) : base(company, model, displaySize, price)
        {
            this.operatingSystem = operatingSystem;
            this.memory = memory;
            this.camera = camera;
            this.color = color;
        }
    }
}
