using System;

namespace SoftUni8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;
            for (int i = 0; i < tabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
                string tab = Console.ReadLine();
                switch (tab)
                {
                    case "Facebook": salary -= FACEBOOK; break;
                    case "Instagram": salary -= INSTAGRAM; break;
                    case "Reddit": salary -= REDDIT; break;
                    default:
                        break;
                }
            }
            Console.WriteLine(salary);
        }
    }
}
