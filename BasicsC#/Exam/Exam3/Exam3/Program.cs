using System;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg = double.Parse(Console.ReadLine());
            string typeOfShipment = Console.ReadLine();
            int kilometras = int.Parse(Console.ReadLine());
            double costPerKilometar = 0;
            double totalMoney;
            double nadcenka = 0;
            switch (typeOfShipment)
            {
                case "standard":
                    if (kg < 1)
                    {
                        costPerKilometar = 0.03;
                    }
                    else if (kg >= 1 && kg < 10)
                    {
                        costPerKilometar = 0.05;
                    }
                    else if (kg >= 10 && kg < 40)
                    {
                        costPerKilometar = 0.1;
                    }
                    else if (kg >= 40 && kg < 90)
                    {
                        costPerKilometar = 0.15;
                    }
                    else if (kg >= 90 && kg < 150)
                    {
                        costPerKilometar = 0.2;
                    }
                    break;
                case "express":
                    if (kg < 1)
                    {
                        costPerKilometar = 0.03;
                        nadcenka = costPerKilometar * 0.8;
                    }
                    else if (kg >= 1 && kg < 10)
                    {
                        costPerKilometar = 0.05;
                        nadcenka = costPerKilometar * 0.4;
                    }
                    else if (kg >= 10 && kg < 40)
                    {
                        costPerKilometar = 0.1;
                        nadcenka = costPerKilometar * 0.05;
                    }
                    else if (kg >= 40 && kg < 90)
                    {
                        costPerKilometar = 0.15;
                        nadcenka = costPerKilometar * 0.02;
                    }
                    else if (kg >= 90 && kg < 150)
                    {
                        costPerKilometar = 0.2;
                        nadcenka = costPerKilometar * 0.01;
                    }
                    break;
            }
            totalMoney = (costPerKilometar * kilometras) + (nadcenka * kilometras * kg);
            Console.WriteLine($"The delivery of your shipment with weight of {kg:f3} kg. would cost {totalMoney:f2} lv.");
        }
    }
}
