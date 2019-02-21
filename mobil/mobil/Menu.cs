using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobil
{   
    class Menu : Alkalmazas
    {
            int kivalaszottIndex = 0;
            int alkalmazasIndex = 0;

        public override void Input(char c)
        {

           
            
            if (c == '4')
            {
                 switch(alkalmazasIndex)
                {
                    case 0:
                        Telefonkonyv telefonkonyv = new Telefonkonyv();
                        Program.aktivAlkalmazas = telefonkonyv;
                        telefonkonyv.Megnyit();
                        break;
                    case 2:
                        Jegyzettomb jegyzettomb = new Jegyzettomb();
                        Program.aktivAlkalmazas = jegyzettomb;
                        jegyzettomb.Megnyit();
                        break;
                    

                }
            } else
             {

                if (c == '5')
                {
                    alkalmazasIndex--;
                }

                if (c == 'T')
                {
                    alkalmazasIndex++;

                }
                if (alkalmazasIndex == 0)
                {
                    Program.Torol();
                    Program.Kozepre(0, "Telefonkönyv" + " <");
                    Program.Kozepre(1, "Hívás kezdeményezése");
                    Program.Kozepre(2, "Jegyzettömb");
                }


                if (alkalmazasIndex == 1)
                {
                    Program.Torol();
                    Program.Kozepre(0, "Telefonkönyv");
                    Program.Kozepre(1, "Hívás kezdeményezése" + " <");
                    Program.Kozepre(2, "Jegyzettömb");
                }

                if (alkalmazasIndex == 2)
                {
                    Program.Torol();
                    Program.Kozepre(0, "Telefonkönyv");
                    Program.Kozepre(1, "Hívás kezdeményezése");
                    Program.Kozepre(2, "Jegyzettömb" + " <");
                }

                if (alkalmazasIndex >= 3)
                {
                    alkalmazasIndex = 2;
                }
                if (alkalmazasIndex < 0)
                {
                    alkalmazasIndex = 0;
                }

            }



        }

        public override void Megnyit()
        {

            Program.aktivAlkalmazas = this;
            Program.Torol();
            Program.Kozepre(0, "Telefonköny");
            Program.Kozepre(1, "Hívás kezdeményezése");
            Program.Kozepre(2, "Jegyzettömb");
        }
    }
}
