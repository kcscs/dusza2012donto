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

            if (c == 'T' && alkalmazasIndex < 2)
            {
                alkalmazasIndex++;

            }
            if (c == '5' && alkalmazasIndex < 0)
            {
                alkalmazasIndex--;
            }
            if (c == '4')
            {
                kivalaszottIndex = alkalmazasIndex;
            }

            if(alkalmazasIndex==0)
            {
                Program.Torol();
                Program.Kozepre(0, "Telefonköny" + " <");
            }
            if(alkalmazasIndex==1)
            {
                Program.Torol();
                Program.Kozepre(1, "Hívás kezdeményezése" + " <");
            }


        }

        public override void Megnyit()
        {

            Program.aktivAlkalmazas = this;
            Program.Torol();
            Program.Kozepre(0, "Telefonköny");
            Program.Kozepre(1, "Hívás kezdeményezése");
        }
    }
}
