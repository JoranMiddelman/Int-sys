using System.Reflection;

namespace Prolog
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("geef input: ");
            string input = Console.ReadLine();
            string[] values = input.Split();
            int v = int.Parse(values[1]);
            int Fs = int.Parse(values[2]);
            string[] clauses = new string[v];
            string[] formules = new string[Fs];
            for (int i = 0; i < v; i++)
            {
                string clause = Console.ReadLine();
                clauses[i] = clause;
            }

            for (int x = 0; x < Fs; x++)
            {
                string formule = Console.ReadLine();
                formules[x] = formule;
            }
            
            bool[] bool_Cl = new bool[v];
            for (int y = 0; y < v; y++)
            {
                if (clauses[y].Contains(":-") == true)
                {
                    bool_Cl[y] = false;
                }
                else
                {
                    bool_Cl[y] = true;
                }
            }

            Console.WriteLine(bool_Cl[3]);








        }
    }
}
//% 7 3 b f b t bla