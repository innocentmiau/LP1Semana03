using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = args[0];
            List<char> letters = new[] { 'w', 's', 'a', 'd' }.ToList();
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
            List<Perks> perkList = Enum.GetValues(typeof(Perks)).Cast<Perks>().ToList();
            string text = "";
            for (int i = 0; i < 4; i++)
            {
                perks[i] = counting[i] % 2 != 0;
                if (perks[i])
                {
                    text += perkList[i] + ", ";
                }
            }

            text = text.Substring(0, text.Length - 2);

            if (perks[0] == false && perks[1] == false && perks[2] == false && perks[3] == false)
            {
                Console.WriteLine("!No perks at all!");
            }
            else
            {
                Console.WriteLine(text);
                if (perks[1] && perks[3]) Console.WriteLine("!Silent jumper!");
                if (!perks[2]) Console.WriteLine("!Not gonna make it!");
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
