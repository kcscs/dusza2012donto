using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobil
{
    class Telefonkonyv : Alkalmazas
    {
        string tSzam;
        string nev;
        char parancs;
        StringBuilder beirt = new StringBuilder();
        Dictionary<string ,string> nevjegyzekek=new Dictionary<string, string>();
        List<string> nevek = new List<string>();
        
        public override void Input(char c)
        {
            
        }
        public override void Megnyit()
        {

            /*int kijelolt;
            Program.Torol();
            foreach (var i in nevjegyzekek)
            {
                //Console.WriteLine(i.Value);
                nevek.Add(i.Value);
                
            }
            for(int j=0; j<15; j++)
            {
                if(kijelolt>=0)
                {
                        if(j==kijelolt)
                        {
                            Console.ForegroundColor=ConsoleColor.Green;
                            nevek[kijelolt] = nevek[kijelolt] + " <";
                            Program.Kozepre(j, nevek[j]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine(nevek[j]);
                        }
                        
                }
            }
            Console.WriteLine("Új névjegy létrehozása");
            if(c==5)
            {
                kijelolt--;
                Megnyit();
                /*Console.Clear();
                for(int j=0; j<15; j++)
                {
                    if(kijelolt>=0)
                    {
                            if(j==kijelolt)
                            {
                                Console.ForegroundColor=ConsoleColor.Green;
                                szamok[kijelolt] = szamok[kijelolt] + " <";
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine(szamok[j]);
                            }
                    }
                }
                Console.WriteLine("Új névjegy létrehozása");*/
            /*}
            if(c==T)
            {
                kijelolt++;
                Megnyit();
                /*Console.Clear();
                for(int j=0; j<15; j++)
                {
                    if(kijelolt>=0)
                    {
                            if(j==kijelolt)
                            {
                                Console.ForegroundColor=ConsoleColor.Green;
                                szamok[kijelolt] = szamok[kijelolt] + " <";
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine(szamok[j]);
                            }
                    }
                }
                Console.WriteLine("Új névjegy létrehozása");*/
            /*}
            if(c==4)
            {

            }
            if(kijelolt==16)
            {
                if(c==4)
                {
                    Console.Write("Név: ");
                    string ujnev=Console.ReadLine();
                    Console.Write("Telefon szám: ");
                    string ujszam = Console.ReadLine();
                    nLetrehoz(ujszam, ujnev);
                }
            }
            */

        }
        public void nLetrehoz(string ujSzam, string ujNev)
        {
            nevjegyzekek.Add(ujSzam, ujNev);
        }
        public void nTorol(string tSzam)
        {
            nevjegyzekek.Remove(tSzam);
        }
    }
}
