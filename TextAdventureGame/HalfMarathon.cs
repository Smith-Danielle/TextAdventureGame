using System;
using System.Threading;
namespace TextAdventureGame
{
    public class HalfMarathon
    {
        public HalfMarathon()
        {
        }

        public void RunHalfMarathon()
        
        {
            Runner user;
            do
            {
                Console.WriteLine("Welcome to the 2021 Summer Half Marathon (13.1 miles)!");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Complete the race as fast as you can.");
                Console.WriteLine("You will begin the race at full Strength with 100 units.");
                Console.WriteLine("Don't forget to stay hydrated. There will be four resting stations throughout the race.");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Please press enter to continue.");

                Console.ReadLine();
                Console.Clear();
                user = new Runner();

                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Lets get started! Press enter to start the race.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("READY.......");
                Thread.Sleep(1300);
                Console.WriteLine("SET........");
                Thread.Sleep(1300);
                Console.WriteLine("GOOOO!!!!");
                Thread.Sleep(1300);
                Console.Clear();

                user.Run();
                Console.WriteLine($"After breezing past mile 1 and 2, you've made it to your first resting station. Congrats racer {user.RunnerNumber}!! 11 miles to go!!");
                Console.WriteLine("Keep in mind that after you reach each resting station your Strength is reduced by 50 units and your Time Lapsed is increased by 10 minutes");
                user.Station1();

                Console.WriteLine($"Way to go racer {user.RunnerNumber}!! You've made it through miles 3, 4, and 5. There are 8 miles left in the race.");
                user.Station2();

                Console.WriteLine($"You are now more than half way through the race, completing miles 6, 7, and 8. Good job racer {user.RunnerNumber}!! 5 miles left!");
                user.Station3();

                if (user.EndRace == false)
                {
                    Console.WriteLine($"Welcome to the last resting station racer {user.RunnerNumber}!! Miles 9 and 10 are now behind you. The race ends in 2 miles.");
                    user.Station4();
                    Console.WriteLine($"Congratulations racer {user.RunnerNumber} you've made it to the finish line!");
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    Console.WriteLine($"Here are your final stats: Time Lapsed = {user.Time} minute(s) | Strength = {user.Strength} unit(s) ");
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    user.Placement();
                }
                else if (user.EndRace == true)
                {
                    Console.WriteLine($"Congratulations racer {user.RunnerNumber} you've made it to the finish line!");
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    Console.WriteLine($"Here are your final stats: Time Lapsed = {user.Time} minute(s) | Strength = {user.Strength} unit(s) ");
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    user.Placement();
                }


            } while (user.Restart == true);
        }
    }
}
