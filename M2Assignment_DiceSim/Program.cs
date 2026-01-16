using M2Assignment_DiceSim;

internal class Program
{
    private static void Main(string[] args)
    {
        // Welcome statements
        Console.WriteLine($"Welcome to Lincoln's double dice simulator!\n");
        Console.WriteLine($"How many dice rolls would you like to simulate?");

        // Get user input for dice rolls
        int numRolls;
        numRolls = int.Parse(Console.ReadLine());

        Sim sim = new Sim(); // Creating new instance of the "Sim" class
        int[] diceRolls = sim.DiceRoll(numRolls); // Assigning the return array of dice rolls to an array

        PrintHist(diceRolls, numRolls); // Calls method to print histogram based on percentage of total rolls and simulated frequency

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }

    private static void PrintHist(int[] diceRolls, int numRolls)
    {
        int percentage = 0; // Initializes percentage variable

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.");
        Console.WriteLine();

        for (int i = 2; i <= 12; i++) // Loops through 2-12 (possible dice results)
        {
            percentage = (int)((diceRolls[i] / (double)numRolls) * 100); // Converts results to percentage of total
            Console.WriteLine(i + ": " + new string('*', percentage)); // Prints frequency as histogram
        }
    }
}