// See https://aka.ms/new-console-template for more information
using dnd5e_cs;
using dnd5e_cs.Dice;
using static dnd5e_cs.Dice.DiceBag;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        GameRules gameRules = new GameRules();

        Dice[] diceValues = (Dice[])Enum.GetValues(typeof(Dice));

        foreach (Dice dice in diceValues)
        {
            Console.WriteLine($"Roll a D{(int)dice} -> {gameRules.DiceBag.Roll(dice)}");
        }

        Dice diceToRoll = Dice.D10;
        int numberOfTimes = 10;

        List<int> diceRolls = gameRules.DiceBag.RollQuantity(diceToRoll, numberOfTimes);

        Console.WriteLine($"Roll {numberOfTimes} x D{(int)diceToRoll}");
        Console.WriteLine($"Avg: {numberOfTimes * (int)diceToRoll / 2.0f}");
        Console.WriteLine($"Max {numberOfTimes * (int)diceToRoll}");

        int total = 0;
        foreach (int roll in diceRolls)
        {
            Console.WriteLine($"Rolled a {roll}");
            total += roll;
        }

        Console.WriteLine($"Roll 10 x D10 (total = {total})");

        //Abilities abilities = new Abilities()
        //{
        //    Strength = 8, Charisma = 8, Constitution = 8, Dexterity = 8, Intelligence = 8, Wisdom = 8
        //};

        PlayerCharacter player = new PlayerCharacter("Zarhog Bonesplitter", 15, 8, 16, 8, 14, 9);

        Console.WriteLine(player.ToString());

        Console.ReadLine();
    }
}