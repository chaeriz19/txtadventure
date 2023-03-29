namespace AdventureGame
{
    class AdventureGame
    {
        public static string showhp (int health)
        {
            string i;
            i = "(" + health + ")";
            return i;
        }
        static void Main(string[] args)
        {  // create objects
            Random rnd = new Random();
            enemy enemy1 = new enemy();
            player player = new player();

            // set properties
            player.health = 100;
            player.min_damage = 15;
            player.max_damage = 25;
            
            enemy1.name = "The Rizzard";
            enemy1.health = 125;
            enemy1.min_damage = 25;
            enemy1.max_damage = 40;


            bool running = true; 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(enemy1.name + showhp(enemy1.health) + " has appeared!");

            // game loop
            while (running) {
                player.damage = rnd.Next(player.min_damage, player.max_damage);
                enemy1.damage = rnd.Next(enemy1.min_damage, enemy1.max_damage);

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
                    enemy1.health -= player.damage;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You attacked " + enemy1.name + " for " + player.damage + " damage.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( enemy1.name+ showhp(enemy1.health) + ": Auch!");
                }
            }
          
        }
    }
}


