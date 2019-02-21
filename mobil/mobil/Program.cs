using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mobil
{
    class Program
    {
        const double kepfrissites = 1.0 / 30;

        static DateTime utolsoFrissites;
        static char[,] puffer = new char[30, 20]; 
        static void Main(string[] args) {
            utolsoFrissites = DateTime.Now;
            Thread t = new Thread(Hatter.Futtat);
            t.Start();

            Console.SetWindowSize(30, 21);
            Console.CursorVisible = false;
            Console.CursorTop = 21;

            Write(0, 0, "ABCDEF");

            while(true)
            {
                if((DateTime.Now - utolsoFrissites).TotalSeconds>=kepfrissites)
                {
                    Rajzol();
                }
            }
        }

        static void Rajzol()
        {
            utolsoFrissites = DateTime.Now;
            Console.Clear();
            for(int i=0;i<30;i++)
            {
                for(int j=0;j<20;j++)
                {
                    Console.Write(puffer[i,j]);
                }
                Console.WriteLine();
            }
            
        }

        public static void Write(int x, int y, string szoveg)
        {
            for(int i=0;i<szoveg.Length;i++)
            {
                puffer[x, y + i] = szoveg[i];
            }
        }
    }
}
