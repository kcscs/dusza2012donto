using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobil
{
    static class Hatter
    {
        public static bool csakSzamMod = false;

        readonly static ConsoleKey[] kozvetlenGomb = new ConsoleKey[] { ConsoleKey.D4, ConsoleKey.D5, ConsoleKey.D6, ConsoleKey.T, ConsoleKey.D1 };

        private readonly static TimeSpan maxDelay = new TimeSpan(0, 0, 2);
        private const char torolChar = '#';
        private static readonly Dictionary<ConsoleKey, char[]> karSorok = new Dictionary<ConsoleKey, char[]>() {
            { ConsoleKey.D2, new char[] { 'a', 'b', 'c', '2'} },
            { ConsoleKey.D3, new char[] { 'd', 'e', 'd', '3'} },
            { ConsoleKey.Q, new char[] { 'g', 'h', 'i', '4'} },
            { ConsoleKey.W, new char[] { 'j', 'k', 'l', '5'} },
            { ConsoleKey.E, new char[] { 'm', 'n', 'o', '6'} },
            { ConsoleKey.A, new char[] { 'p', 'q', 'r', 's', '7' } },
            { ConsoleKey.S, new char[] { 't', 'u', 'v', '8'} },
            { ConsoleKey.D, new char[] { 'w', 'x', 'y', 'z', '9'} },
            { ConsoleKey.Z, new char[] { '*', '+'} },
            { ConsoleKey.X, new char[] { ' ', '0'} }//,
            //{ ConsoleKey.C, new char[] { '#', '.'} }
        };

        public static void Futtat() {
            char elozoKarakter = ',';
            ConsoleKey elozoGomb = ConsoleKey.Escape;
            int elozoDb = 0;
            DateTime elozoIdo = new DateTime(DateTime.Now.Year - 1, 1, 1);

            while (true) {
                ConsoleKeyInfo k = Console.ReadKey();
                int i = 0;
                while (i < kozvetlenGomb.Length && kozvetlenGomb[i] != k.Key)
                    ++i;
                if(i < kozvetlenGomb.Length) {
                    Program.aktivAlkalmazas?.Input(char.ToUpper(k.KeyChar));
                    elozoDb = 0;
                } else {
                    if (k.Key == elozoGomb) {
                        if (DateTime.Now - elozoIdo < maxDelay) {
                            Program.aktivAlkalmazas?.Input(torolChar);
                            Program.aktivAlkalmazas?.Input(getChar(k.Key, elozoDb));
                            elozoDb++;
                        } else {
                            Program.aktivAlkalmazas?.Input(k.KeyChar);
                            elozoDb = 1;
                        }
                        
                    } else {
                        Program.aktivAlkalmazas?.Input(k.KeyChar);
                        elozoDb = 1;
                    }
                }

                elozoIdo = DateTime.Now;
                elozoGomb = k.Key;
                elozoKarakter = k.KeyChar;
            }
        }

        private static char getChar(ConsoleKey gomb, int db) {
            switch (gomb) {
                case ConsoleKey.D2:
                case ConsoleKey.D3:
                case ConsoleKey.Q:
                case ConsoleKey.W:
                case ConsoleKey.E:
                case ConsoleKey.S:
                    return karSorok[gomb][db % 4];
                case ConsoleKey.A:
                case ConsoleKey.D:
                    return karSorok[gomb][db % 5];
                case ConsoleKey.Z:
                case ConsoleKey.X:
                    return karSorok[gomb][db % 2];
            }

            return '.';
        }
    }
}
