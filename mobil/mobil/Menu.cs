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

            if (c == 'T')
            {
                alkalmazasIndex++;

            }
            if (c == '5')
            {
                alkalmazasIndex--;
            }
            if (c == '4')
            {
                 switch(alkalmazasIndex)
                {
                    /*case 0:
                        telefonkonyv telefonkonyv = new telefonkonyv();
                        Program.aktivAlkalmazas = telefonkonyv;
                        break;*/
                    case 2:
                        Jegyzettomb jegyzettomb = new Jegyzettomb();
                        Program.aktivAlkalmazas = jegyzettomb;
                        jegyzettomb.Megnyit();
                        break;
                    

                }
            }

            if(alkalmazasIndex==0)
            {
                Program.Torol();
                Program.Kozepre(0, "Telefonköny" + " <");
                Program.Kozepre(1, "Hívás kezdeményezése");
                Program.Kozepre(2, "Jegyzettomb");
            }


            if(alkalmazasIndex==1)
            {
                Program.Torol();
                Program.Kozepre(0, "Telefonköny");
                Program.Kozepre(1, "Hívás kezdeményezése" + " <");
                Program.Kozepre(2, "Jegyzettomb");
            }

            if(alkalmazasIndex==2)
            {
                Program.Torol();
                Program.Kozepre(0, "Telefonköny");
                Program.Kozepre(1, "Hívás kezdeményezése");
                Program.Kozepre(2, "Jegyzettomb" + " <");
            }

            if(alkalmazasIndex>3)
            {
                alkalmazasIndex = 3;
            }
            if(alkalmazasIndex<0)
            {
                alkalmazasIndex = 0;
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
