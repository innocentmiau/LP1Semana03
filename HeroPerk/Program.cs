using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> letters = new[] { 'w', 'a', 's', 'd' }.ToList();
            int[] counting = new[] { 0, 0, 0, 0 };
            foreach (char c in input)
            {
                if (!letters.Contains(c))
                {
                    Console.WriteLine("!Unknown perk!");
                    return;
                }

                counting[letters.IndexOf(c)] += 1;
            }

            bool[] perks = new[] {false, false, false, false};
            for (int i = 0; i < 4; i++)
            {
                perks[i] = counting[i] % 2 == 0;
            }

            List<Perks> perkList = Enum.GetValues(typeof(Perks)).Cast<Perks>().ToList();
            foreach (Perks perk in perkList)
            {
                Console.WriteLine($"{perk.ToString()}: {perks[perkList.IndexOf(perk)]}");
            }

        }
    }

    [Flags]
    public enum Perks
    {
        WarpShift = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
}
