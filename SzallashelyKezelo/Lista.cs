using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzallashelyKezelo
{
    internal class Lista : List<Szallashely>
    {
        public delegate void UjSzallashelyEsemenyKezelo(Szallashely ujSzallashely);

        public event UjSzallashelyEsemenyKezelo UjSzallashely;

        public new void Add(Szallashely szallashely)
        {
            base.Add(szallashely);
            UjSzallashely?.Invoke(szallashely);
        }
    }
}
