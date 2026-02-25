namespace mini_adventure_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, little player! I'm Ellie, and today I'll present to you \" Escape Castle - Text Adventure game\". Hope you enjoy, because it took quite some time to make it:D");

            Console.WriteLine();
            
            Console.WriteLine("BUT FIRST BEFORE WE START THE GAME - what is your name?");
            
            string name = Console.ReadLine();
            List<string> inventory = new List<string>();
            Character character = new Character(name, inventory);

            Console.WriteLine($"*{character.Name} wakes up.*");

        }
    }
}
