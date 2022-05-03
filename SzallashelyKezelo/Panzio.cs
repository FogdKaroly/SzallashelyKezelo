using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzallashelyKezelo
{
    internal class Panzio : EpitettSzallashely
    {
        bool reggeliE;

        public bool ReggeliE { get => reggeliE; }

        public Panzio(bool reggeliE, int szobaar, byte csillagok, string? id, Fajta fajta, Cim cim) : base(szobaar, csillagok, id, fajta, cim)
        {
            this.reggeliE = reggeliE;
        }

        public double Arszamitas()
        {
            return Szobaar + (Szobaar / 10 * Csillagok);
        }

        private string Reggeli()
        {
            if (reggeliE)
            {
                return "Reggelivel";
            }
            return "Reggeli nélkül";
        }

        public override string ToString()
        {
            return $"Panzió: [{Id}] - Fajta: {Fajta} ({Cim.Iranyitoszam} {Cim.Varos} {Cim.Utca} {Cim.Hazszam}) - {Csillagok}* - {Reggeli()}";
        }
    }
}
