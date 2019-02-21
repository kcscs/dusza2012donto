using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobil
{
    class telefonkonyv
    {
        string tSzam;
        string nev;
        char parancs;
        Dictionary<string ,string> nevjegyzekek=new Dictionary<string, string>();
        public void bemenet(char input)
        {
            parancs = input;
        }
        public void nLetrehoz(string ujSzam, string ujNev)
        {
            nevjegyzekek.Add(ujSzam, ujNev);
        }
        public void nTorol(string tSzam, string tNev)
        {
            nevjegyzekek.Remove(tSzam);
        }
    }
}
