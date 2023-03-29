namespace AdventureGame
{
    class AdventureGame
    {
        static void Main(string[] args)
        {  // create objects

            Random rnd = new Random();
            enemy enemy1 = new enemy();
            enemy enemy2 = new enemy();

            // properties

            int damage = rnd.Next(15,115);
            // enemy handling

            enemy1.name = "The Rizzard";
            enemy2.name = "El Goblino";
            enemy1.health = 85;
            enemy2.health = 125;

            // functions 

            string showhp(int health)
            {
                string i;
                i = "(" + health + ")";
                return i;
            }

            bool running = true; 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(enemy1.name + showhp(enemy1.health) + " has appeared!");

            // game loop

            while (running){
                // generate random properties
                damage = rnd.Next(15, 55);

                // set negative values to 0
                if (enemy1.health <= 0) { enemy1.health = 0; }

                // check enemy health
                if (enemy1.health <= 0){
                    // end game on win
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.WriteLine("You won!");
                    Console.WriteLine("");
                    running = false;
                    break;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" >> What would you like to do next?");
                string input = Console.ReadLine();
                if (input == "attack"  || input == "a")
                {
                    enemy1.health -= damage;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You attacked " + enemy1.name + " for " + damage + " damage.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( enemy1.name+showhp(enemy1.health) + ": Auch!");
                }
            }
          
        }
    }
}


