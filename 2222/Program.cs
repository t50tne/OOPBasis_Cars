using System;
using System.Runtime.ConstrainedExecution;

namespace OOPBasis_Cars
{
    class MyMain
    {
        static void Main()
        {
            Car Toyota = new Car();
            Toyota.setModel("CHR");
            Toyota.Color = "white";
            Toyota.Year = 2018;
            Toyota.MaxSpeed = 300;
            Toyota.CC = 2.0;
            Toyota.SetHorsePower(144);
            Toyota.Acceleration = 10.9;
            Toyota.Cylinder = 4;

            Car Nissan = new Car();
            Nissan.setModel("Juke");
            Nissan.Color = "green";
            Nissan.Year = 2011;
            Nissan.MaxSpeed = 280;
            Nissan.CC = 1.6;
            Nissan.SetHorsePower(188);
            Nissan.Acceleration = 10.6;
            Nissan.Cylinder = 4;

            Car Porsche = new Car();
            Porsche.setModel("911 GT3");
            Porsche.Color = "blue";
            Porsche.Year = 2019;
            Porsche.MaxSpeed = 318;
            Porsche.CC = 4.0;
            Porsche.SetHorsePower(500);
            Porsche.Acceleration = 3.9;
            Porsche.Cylinder = 6;

            Car Pagani = new Car();
            Pagani.setModel("Zonda R");
            Pagani.Color = "black";
            Pagani.Year = 2011;
            Pagani.MaxSpeed = 350;
            Pagani.CC = 6.0;
            Pagani.SetHorsePower(800);
            Pagani.Acceleration = 2.7;
            Pagani.Cylinder = 12;

            Nissan.getFullDetails();
            Toyota.getFullDetails();
            Porsche.getFullDetails();
            Pagani.getFullDetails();
        }

    }
}