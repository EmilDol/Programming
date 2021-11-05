using System;

namespace ExperienceGaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExp = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            
            double gainedExp = 0;
            
            for (int i = 1; i <= countOfBattles; i++)
            {
                double expPerBattle = double.Parse(Console.ReadLine());
                gainedExp += expPerBattle;
                if (i % 3 == 0)
                {
                    gainedExp += (expPerBattle * 0.15);
                    
                }

                if (i % 5 == 0)
                {
                    gainedExp -= (expPerBattle * 0.1);
                }

                if (i % 15 == 0)
                {
                    
                    gainedExp += (gainedExp * 0.05);
                }

                
                if (gainedExp >= neededExp)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }

            Console.WriteLine($"Player was not able to collect the needed experience, {(neededExp - gainedExp):f2} more needed.");
        }
    }
}
