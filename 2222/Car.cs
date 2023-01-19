using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasis_Cars
{
    class Car
    {
        // variable
        private string model = "Unknown";
        private int maxspeed;
        private double cc;
        private int horsePower;
        private int cylinder;
        public string getModel()
        {
            return model;
        }
        public void setModel(string model)
        {
            this.model = model;
        }

        public int GetHorsePower()
        {
            return horsePower;
        }
        public void SetHorsePower(int horsePower)
        {
            this.horsePower = horsePower;
        }

        // Propertties
        public string Color { get; set; } = "Unknown";
        public int Year { get; set; }
        public double Acceleration { get; set; }

        // Third Way
        public int MaxSpeed
        {
            get
            {
                return maxspeed;
            }

            set
            {
                maxspeed = value;
            }
        }

        public double CC
        {
            get
            {
                return cc;
            }

            set
            {
                cc = value;
            }
        }

        public int Cylinder
        {
            get
            {
                return cylinder;
            }
            set
            {
                cylinder = value;
            }
        }

        public void getFullDetails()
        {
            Console.WriteLine("Model: {0}", getModel());
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Year: {0}", Year);
            Console.WriteLine("Max Speed: {0}", MaxSpeed);
            Console.WriteLine("Engine: {0}", CC);
            Console.WriteLine("Horse Power: {0}", GetHorsePower());
            Console.WriteLine("Acceleration: 0 -> 100 km/h: {0}", Acceleration);
            Console.WriteLine("Number Of Cylinders: {0}", Cylinder);
            Console.WriteLine();
        }
    }
}
