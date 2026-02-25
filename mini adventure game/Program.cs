namespace mini_adventure_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, little player! I'm Elix, and you are currently trapped in a cage inside a castle full of monsters. " +
                "You have to make your way out. I have left some notes around the castle to help you find the exit. But I have to warn you — BE VERY QUIET!!! " +
                "The monsters have very bad sight, but their hearing is unmatched. So don't make too much noise. Good luck :)");

            Console.WriteLine();
            
            Console.WriteLine("BUT FIRST - what is your name?");
            string name = Console.ReadLine();
            List<string> inventory = new List<string>(); 
            Character character = new Character(name, inventory);

            Console.WriteLine($"Welcome, {character.Name}! Let's start your adventure!");

        }
    }
}
