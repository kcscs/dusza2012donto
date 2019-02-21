using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace mobil
{
    class Program
    {

        static bool frissultE;
        const double kepfrissites = 1.0 / 60;
        //[DllImport("kernel32.dll")]
        //static extern void OutputDebugString(string lpOutputString);    
        static DateTime utolsoFrissites;
        static char[,] puffer = new char[20, 30];
        public static Menu menu = new Menu();
        public static Alkalmazas aktivAlkalmazas = null;
        static void Main(string[] args) {
            utolsoFrissites = DateTime.Now;
            Thread t = new Thread(Hatter.Futtat);
            t.Start();

            Console.SetWindowSize(30, 21);
            Console.CursorVisible = false;
            Console.CursorTop = 20;

            Write(0, 0, "ABCDEF");
            Kozepre(9, "K");
            Kozepre(10, "KOZEPRE");
            Kozepre(11, "KOZEPERIGAZITAS");
            Torol();

           
            menu.Megnyit();
            

            while(true)
            {
                if((DateTime.Now - utolsoFrissites).TotalSeconds>=kepfrissites && frissultE == true)
                {
                    Rajzol();
                }
            }
        }

        

        
        static void Rajzol()
        {
            frissultE = false;
            utolsoFrissites = DateTime.Now;
            Console.Clear();
            for(int i=0;i<20;i++)
            {
                for(int j=0;j<30;j++)
                {
                    Console.Write(puffer[i,j]);
                }
                //OutputDebugString("\n");
                if(i<29)
                {
                    Console.WriteLine();
                }
            }
            
        }

        public static void Write(int x, int y, string szoveg)
        {
            frissultE = true;
            for(int i=0;i<szoveg.Length;i++)
            {
                puffer[y , x+i] = szoveg[i];
            }
            
        }

        public static void Kozepre(int sor, string szoveg)
        {
            frissultE = true;
            for(int i=0;i<szoveg.Length;i++)
            {   
                puffer[sor, (30 / 2) - (szoveg.Length / 2) + i - 1] = szoveg[i]; 
            }
        }

        public static void Torol()
        {
            frissultE = true;
            for(int i=0;i<20;i++)
            {
                for(int j=0;j<30;j++)
                {
                    puffer[i, j] = ' ';
                }
            }
        }


    }
}
