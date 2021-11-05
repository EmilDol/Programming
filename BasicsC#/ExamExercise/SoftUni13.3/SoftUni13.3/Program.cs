using System;

namespace SoftUni13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stateOfTournament = Console.ReadLine();
            string typeOfTicket = Console.ReadLine();
            int countOfTickets = int.Parse(Console.ReadLine());
            string photo = Console.ReadLine();
            double totalMoney;
            double priceOfTicket = 0;
            switch (stateOfTournament)
            {
                case "Quarter final":
                    switch (typeOfTicket)
                    {
                        case "Standard":
                            priceOfTicket = 55.5;
                            break;
                        case "Premium":
                            priceOfTicket = 105.2;
                            break;
                        case "VIP":
                            priceOfTicket = 118.9;
                            break;
                    }
                    break;
                case "Semi final":
                    switch (typeOfTicket)
                    {
                        case "Standard":
                            priceOfTicket = 75.88;
                            break;
                        case "Premium":
                            priceOfTicket = 125.22;
                            break;
                        case "VIP":
                            priceOfTicket = 300.4;
                            break;
                    }
                    break;
                case "Final":
                    switch (typeOfTicket)
                    {
                        case "Standard":
                            priceOfTicket = 110.1;
                            break;
                        case "Premium":
                            priceOfTicket = 160.66;
                            break;
                        case "VIP":
                            priceOfTicket = 400;
                            break;
                    }
                    break;
            }
            totalMoney = priceOfTicket * countOfTickets;
            if (totalMoney > 4000)
            {
                photo = "N";
                totalMoney *= 0.75;
            }
            else if (totalMoney > 2500)
            {
                totalMoney *= 0.9;
            }
            if (photo == "Y")
            {
                totalMoney += countOfTickets * 40;
            }
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
