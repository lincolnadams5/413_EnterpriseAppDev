

using VideoWalkthrough_M3;

internal class Program
{
    private static void Main(string[] args)
    {
        /* User enters quote and program returns the following:
            * Word count
            * Character count
            * Letter frequency
        */

        WordTools wt = new WordTools();

        string quote = "";

        Console.WriteLine("Please enter a quote: ");
        quote = Console.ReadLine();

        Console.WriteLine("Number of Words: " + wt.WordCounter(quote));
        Console.WriteLine("Number of Characters: " + wt.CharCounter(quote));
        Console.WriteLine("Character Frequency: \n\n" + wt.AlphCounter(quote));
    }
}