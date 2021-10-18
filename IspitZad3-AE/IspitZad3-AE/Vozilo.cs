using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitZad3_AE
{
    class Vozilo
    {
        bool JeLiLeti, JeLiPlovi;

        public Vozilo(bool jeLiLeti, bool jeLiPlovi)
        {
            JeLiLeti = jeLiLeti;
            JeLiPlovi = jeLiPlovi;
        }

        public void KudaVozi()
        {
            Console.WriteLine("Da li leti: " + JeLiLeti + "\n" + "Da li plovi: " + JeLiPlovi + "\n");

        }
    }
}
