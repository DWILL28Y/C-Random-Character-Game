// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        int Strength = 5;
        int Perception = 5;
        int Charisma = 5;
        int Intelligence = 5;
        int Luck = 5;

        int RemainingABalance = 7;

        Console.WriteLine("Hello, it is time to assign your character atributes and skills");
        Console.WriteLine("You will go through each attribute and input the number of points you want for each one. Each sttribute will start at 5, " +
            "you must assign the remaining points to the ones you feel fit for your character");
        Console.WriteLine("You will have a starting point balance of 7");

        Console.WriteLine("Please enter the Number of points you want to assign toward each attribute, when you run out of points you will move onto your characters individual skills");

        do
        {
            Console.WriteLine($"Strength: {Strength}     Remaining points: {RemainingABalance}");
            int StrengthInput = Convert.ToInt32(Console.ReadLine());
            RemainingABalance = RemainingABalance - StrengthInput;

            Console.WriteLine($"Perception: {Perception}    Remaining Points: {RemainingABalance}");
            int PerceptionInput = Convert.ToInt32(Console.ReadLine());

        } while (RemainingABalance > 0);






    }
}
