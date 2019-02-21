using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobil
{
    class Jegyzettomb : Alkalmazas
    {
        int cursorPos = 0;
        public override void Input(char c) {
            if(c == '#') {
                cursorPos--;
                Program.Write(cursorPos, 0, " ");
            } else {
                Program.Write(cursorPos, 0, c.ToString());
                ++cursorPos;
            }
        }
        public override void Megnyit() {
            Program.Torol();
        }
    }
}
