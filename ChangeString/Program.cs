using System;
using System.Text;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite um texto:");
            string input = Console.ReadLine();
            Console.Write("Digite um caracter:");
            char input2 = char.Parse(Console.ReadLine());
            foreach (char c in input)
            {
                char toAdd = c == input2 ? 'x' : c;
                Console.Write(toAdd);
            }
            
        }
    }
}
