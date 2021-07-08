using System;
namespace TextAdventureGame
{
    public class Runner
    {
        public Runner()
        {
            do
            {
            Console.WriteLine("Please enter your desired race number or type other to be assigned a random number.");
            string response = Console.ReadLine();
            int numResponse;

                if (int.TryParse(response, out numResponse))
                {
                    if (numResponse > 0)
                    {
                        RunnerNumber = Convert.ToInt32(response);
                        Console.WriteLine($"Perfect! You're race number is {RunnerNumber}!");
                    }
                }
                else
                {
                    if (response.ToLower() == "other")
                    {
                        Random ranNum = new Random();
                        RunnerNumber = ranNum.Next(0, 500);
                        Console.WriteLine($"You're race number is {RunnerNumber}!");
                        break;
                    }
                }     
            } while (RunnerNumber == 0);
        }

        public int RunnerNumber { get; set; } = 0;
        public int Strength { get; set; } = 100;
        public int Time { get; set; } = 0;
        public bool CanPass { get; set; } = false;
        public bool EndRace { get; set; } = false;
        public bool Restart { get; set; } = true;

        public void Run()
        {
            
            if (Strength >= 50)
            {
                Strength -= 50;
                Time += 10;
                CanPass = true;

                
            }
            else
            {
                Console.WriteLine("You dont have enough Strength to run. Must have at least 50 units to run. Try to Hydrate first.");
            }
            
        }
        public void Hydrate()
        {
            if (Strength >= 100)
            {
                Console.WriteLine($"You already have {Strength} Strength units. You can only Hydrate if your Strength is under 100.");
            }

            else
            {
                if (Strength + 16 <= 100)
                {
                    Strength += 16;
                    Time += 8;
                    Console.WriteLine($"Thirst Quenched!");
                }
                else
                {
                    Strength += (100 - Strength);
                    Time += 8;
                    Console.WriteLine($"Thirst Quenched!");
                }
            }
        }
        public void Station1()
        { 
            CanPass = false;
            do
            {
                bool answer;
                do
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"Racer {RunnerNumber}'s Current Stats: Time Lapsed = {Time} minute(s) | Strength = {Strength} unit(s) ");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Resting Station 1");
                    Console.WriteLine("What would you like to do next? Please enter a number from the following.");
                    Console.WriteLine("1: Hydrate (Increases Strength by 16, Increases Time Lapsed by 8)");
                    Console.WriteLine("2: Run (Decreases Strength by 50, Increase Time Lapsed by 10)");
                    Console.WriteLine("3: Bonus (Chance to increase your Strength and advance in the race quicker or maybe just the opposite)");
                    int response = 0;
                    answer = int.TryParse(Console.ReadLine(), out response);
                    Console.Clear();
                    
                    if (response == 1)
                    {
                        Hydrate();
                    }
                    else if (response == 2)
                    {
                        Run();
                    }
                    else if ( response == 3)
                    {
                        if (Strength >= 50)
                        {

                            string challenge;
                            do
                            {
                                Console.WriteLine("You have two options to choose from. A or B?");
                                challenge = Console.ReadLine().ToLower();
                                Console.Clear();
                                if (challenge == "a")
                                {
                                    Console.WriteLine("Get lost on the trail but find your way back to the resting station. This cost you 7 extra minutes and reduced your Strength by 12 units");
                                    Strength -= 12;
                                    Time += 7;

                                }
                                else if (challenge == "b")
                                {
                                    Console.WriteLine("Ate a Clif Bar and gained 12 Strength units. Advanced in race.");
                                    Strength += 12;
                                    Strength -= 50;
                                    Time += 10;
                                    CanPass = true;
                                }

                            } while (challenge != "a" && challenge != "b");
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough Strength to do a Bonus. Must have at least 50 units. Try to Hydrate first.");
                        }
                    }

                } while (answer == false);

            } while (CanPass == false);
        }
        public void Station2()
        {
            CanPass = false;
            do
            {
                bool answer;
                do
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"Racer {RunnerNumber}'s Current Stats: Time Lapsed = {Time} minute(s) | Strength = {Strength} unit(s) ");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Resting Station 2");
                    Console.WriteLine("What would you like to do next? Please enter a number from the following.");
                    Console.WriteLine("1: Hydrate (Increases Strength by 16, Increases Time Lapsed by 8)");
                    Console.WriteLine("2: Run (Decreases Strength by 50, Increase Time Lapsed by 10)");
                    Console.WriteLine("3: Bonus (Chance to increase your Strength and advance in the race quicker or maybe just the opposite)");
                    int response = 0;
                    answer = int.TryParse(Console.ReadLine(), out response);
                    Console.Clear();
                  
                    if (response == 1)
                    {
                        Hydrate();
                    }
                    else if (response == 2)
                    {
                        Run();
                    }
                    else if (response == 3)
                    {
                        if (Strength >= 50)
                        {

                            string challenge;
                            do
                            {
                                Console.WriteLine("You have two options to choose from. A or B?");
                                challenge = Console.ReadLine().ToLower();
                                Console.Clear();
                                if (challenge == "a")
                                {
                                    Console.WriteLine("Crowd cheers you on and boosts your adrenaline. Gained 10 Strength units. Advanced in race.");
                                    Strength += 10;
                                    Strength -= 50;
                                    Time += 10;
                                    CanPass = true;

                                }
                                else if (challenge == "b")
                                {
                                    Console.WriteLine("Fell and scraped your knee. You have to go back to the resting station for bandages. This cost you 10 minutes and reduced your Strength by 15.");
                                    Strength -= 15;
                                    Time += 10;
                                }

                            } while (challenge != "a" && challenge != "b");
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough Strength to do a Bonus. Must have at least 50 units. Try to Hydrate first.");
                        }
                    }

                } while (answer == false);

            } while (CanPass == false);
        }

        public void Station3()
        {
            EndRace = false;
            CanPass = false;
            do
            {
                bool answer;
                do
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"Racer {RunnerNumber}'s Current Stats: Time Lapsed = {Time} minute(s) | Strength = {Strength} unit(s) ");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Resting Station 3");
                    Console.WriteLine("What would you like to do next? Please enter a number from the following.");
                    Console.WriteLine("1: Hydrate (Increases Strength by 16, Increases Time Lapsed by 8)");
                    Console.WriteLine("2: Run (Decreases Strength by 50, Increase Time Lapsed by 10)");
                    Console.WriteLine("3: Bonus (Chance to increase your Strength and advance in the race quicker or maybe just the opposite)");
                    int response = 0;
                    answer = int.TryParse(Console.ReadLine(), out response);
                    Console.Clear();
                   
                    if (response == 1)
                    {
                        Hydrate();
                    }
                    else if (response == 2)
                    {
                        Run();
                    }
                    else if (response == 3)
                    {
                        if (Strength >= 50)
                        {

                            string challenge;
                            do
                            {
                                Console.WriteLine("You have two options to choose from. A or B?");
                                challenge = Console.ReadLine().ToLower();
                                Console.Clear();
                                if (challenge == "a")
                                {
                                    Console.WriteLine("Chased by bees. Took detour. You advance in the race but it took you an extra 12 minutes and reduced your Strength by an extra 18 units.");
                                    Strength -= 18;
                                    Strength -= 50;
                                    Time += 12;
                                    Time += 10;
                                    CanPass = true;

                                }
                                else if (challenge == "b")
                                {
                                    Console.WriteLine("Found a shortcut. Skipped the last resting station and made it to the end of the race in 9 minutes. Saved yourself 10 Strength units.");
                                    Strength -= 40;
                                    Time += 9;
                                    CanPass = true;
                                    EndRace = true;
                                    
                                    
                                }

                            } while (challenge != "a" && challenge != "b");
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough Strength to do a Bonus. Must have at least 50 units. Try to Hydrate first.");
                        }
                    }

                } while (answer == false);

            } while (CanPass == false);
        }

        public void Station4()
        {
            CanPass = false;
            do
            {
                bool answer;
                do
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"Racer {RunnerNumber}'s Current Stats: Time Lapsed = {Time} minute(s) | Strength = {Strength} unit(s) ");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Resting Station 4");
                    Console.WriteLine("What would you like to do next? Please enter a number from the following.");
                    Console.WriteLine("1: Hydrate (Increases Strength by 16, Increases Time Lapsed by 8)");
                    Console.WriteLine("2: Run (Decreases Strength by 50, Increase Time Lapsed by 10)");
                    Console.WriteLine("3: Bonus (Chance to increase your Strength and advance in the race quicker or maybe just the opposite)");
                    int response = 0;
                    answer = int.TryParse(Console.ReadLine(), out response);
                    Console.Clear();

                    if (response == 1)
                    {
                        Hydrate();
                    }
                    else if (response == 2)
                    {
                        Run();
                        
                    }
                    else if (response == 3)
                    {
                        if (Strength >= 50)
                        {

                            string challenge;
                            do
                            {
                                Console.WriteLine("You have two options to choose from. A or B?");
                                challenge = Console.ReadLine().ToLower();
                                Console.Clear();
                                if (challenge == "a")
                                {
                                    Console.WriteLine("Drank some Gatorade and powered through to the end of the race. Gained 8 Strength units and shaved 3 minutes off your Time.");
                                    Strength += 8;
                                    Strength -= 50;
                                    Time += 7;
                                    CanPass = true;
                                  

                                }
                                else if (challenge == "b")
                                {
                                    Console.WriteLine("Stopped for a 5 minute bathroom break at the resting station. ");
                                    Time += 5;
                                }

                            } while (challenge != "a" && challenge != "b");
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough Strength to do a Bonus. Must have at least 50 units. Try to Hydrate first.");
                        }
                    }

                } while (answer == false);

            } while (CanPass == false);
        }
        public void Placement()
        {
            if (Time >= 129)
            {
                Console.WriteLine("You did not place. But you get an A for Accomplishing a Half Marathon.");
                Console.WriteLine("Try guessing the correct Bonus options next time to increase your odds.");
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
            else if (Time <= 128 && Time >= 113)
            {
                Console.WriteLine("You came in 3rd place!! Let's go Bronze!!");
                Console.WriteLine("Try guessing the correct Bonus options next time to rank higher.");
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
            else if (Time <= 112 && Time >= 81)
            {
                Console.WriteLine("You came in 2nd place!! Good job Silver!!");
                Console.WriteLine("Try guessing the correct Bonus options next time to rank higher.");
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
            else if (Time <= 80)
            {
                Console.WriteLine("You came in 1st place! Way to go Gold!!");
                Console.WriteLine("You won the 2021 Summer Half Marathon!");
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
            bool ending;
            do
            {
                Console.WriteLine("Select 1 to try again or Select 2 to exit");
                int end = 0;
                ending = int.TryParse(Console.ReadLine(), out end);
                Console.Clear();
                if (end == 1)
                {
                    Restart = true;
                }
                else if (end == 2)
                {
                    Restart = false;
                    Console.WriteLine("Thanks for running!!");
                }

            } while (ending == false);
            

        }
    }
}
