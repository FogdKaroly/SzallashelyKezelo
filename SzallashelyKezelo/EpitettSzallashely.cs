using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzallashelyKezelo
{
    internal class EpitettSzallashely : Szallashely
    {
        int szobaar;
        byte csillagok;

        public int Szobaar { get => szobaar; }
        public byte Csillagok
        { 
            get => csillagok;
            set
            {
                if (value >= 1 && value <= 5)
                {
                    csillagok = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A csillagok száma 1 és 5 közé kell, hogy essen!");
                }
            }
        }

        public EpitettSzallashely(int szobaar, byte csillagok, string? id, Fajta fajta, Cim cim) : base(id, fajta, cim)
        {
            this.szobaar = szobaar;
            Csillagok = csillagok;
        }
    }
}
