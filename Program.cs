using System;

namespace cowdogcop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string answer = "";
            int PlayerCount = 0;
            int CompCount = 0;


            Console.WriteLine(@"
            
                     /)  (\          
                .-._((,~~.))_.-,       
                 `-.   @@   ,-'         
                   / ,o--o. \
                  ( ( .__. ) )
                   ) `----' (
                  /          \ 
                 /            \
                /              \         
                    /  \              
                   /|oo \             
                  (_|  /_)            
                    `@/  \    _       
                    |     \   \\      
                     \||   \   ))     
                     |||\ /  \//      
                   _//|| _\   /       
                  (_/(_|(____/  

                   ,   /\   ,
                  / '-'  '-' \
                  |  POLICE  |
                  |   .--.   |
                  |  ( 21 )  |
                  \   '--'   /
                   '--.  .--'
                       \/
            ");
            while (answer != "NO")
            {
                Console.WriteLine("Choose Wisely: \n->Cow\n->Dog\n->Cop");
                string[] choices = new string[3] { "Cow", "Dog", "Cop" };
                Random rndm = new Random();
                int num = rndm.Next(0, 3);
                Console.WriteLine("Make A Choice & Let FATE DECIDE: ");
                string user = Console.ReadLine();
                Console.WriteLine("Computer:" + choices[num]);

                if (user == "Dog" && choices[num] == "Cop")
                {
                    Console.WriteLine("You LOSE! Cop TAZED Dog ... But he's ok and recovers! Good Puppy!");
                    CompCount += 1;
                }
                else if (user == "Dog" && choices[num] == "Cow")
                {
                    Console.WriteLine("YOU WIN! Dog BITES Cow");
                    PlayerCount += 1;
                }
                else if (user == "Cow" && choices[num] == "Dog")
                {
                    Console.WriteLine("You LOSE! Dog BITES Cow");
                    CompCount += 1;
                }
                else if (user == "Cow" && choices[num] == "Cop")
                {
                    Console.WriteLine("You WIN! Cow KICKS Cop");
                    PlayerCount += 1;
                }
                else if (user == "Cop" && choices[num] == "Cow")
                {
                    Console.WriteLine("You LOSE! Cow KICKS Cop");
                    CompCount += 1;
                }
                else if (user == "Cop" && choices[num] == "Dog")
                {
                    Console.WriteLine("You WIN! Cop TAZED Dog! ... But he's ok and recovers! Good Puppy!");
                    PlayerCount += 1;
                }
                else
                {
                    Console.WriteLine("TIE! ... INCREDIBLE ODDS!!");
                }
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("USER: " + PlayerCount + "------");
                Console.WriteLine("CPU: " + CompCount + "------");
                Console.WriteLine("---------------------------------------");

                Console.WriteLine("Want to play again, Neighbor? (Yes or No)");
                answer = Console.ReadLine().ToUpper();
                Console.WriteLine("----NEXT --||-- BATTLE----");
            }

        }
    }
}
