using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzallashelyKezelo
{
    internal class Szalloda : EpitettSzallashely
    {
        bool wellnessE;

        public bool WellnessE { get => wellnessE; }

        public Szalloda(bool wellnessE, int szobaar, byte csillagok, string? id, Fajta fajta, Cim cim) : base(szobaar, csillagok, id, fajta, cim)
        {
            this.wellnessE = wellnessE;
        }

        public double Arszamitas()
        {
            return Szobaar + (Szobaar / 10 * Csillagok);
        }

        private string Wellness()
        {
            if (wellnessE)
            {
                return "Wellness";
            }
            return "Nem wellness";
        }

        public override string ToString()
        {
            return $"Szálloda: [{Id}] - Fajta: {Fajta} ({Cim.Iranyitoszam} {Cim.Varos} {Cim.Utca} {Cim.Hazszam}) - {Csillagok}* - {Wellness()}";
        }
    }
}
