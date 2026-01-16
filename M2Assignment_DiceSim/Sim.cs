using System;
using System.Collections.Generic;
using System.Text;

namespace M2Assignment_DiceSim
{
    public class Sim
    {
        public int[] DiceRoll(int rolls)
        {
            int[] results = new int[13]; // Initialize an empty array where each index will store the frequency of the roll
            int num = 0; // Will store the temporary value of the roll

            for (int i = 0; i < rolls; i++) // For the amount of rolls specified by the user
            {
                num = Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7); // Simulates dice roll and stores in temporary variable
                results[num] += 1; // Increments frequency by 1 at the index of the result (0 and 1 will remain 0: impossible rolls)
            }
            return results; // Returns results
        }
    }
}
