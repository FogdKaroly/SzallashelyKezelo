using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzallashelyKezelo
{
    internal class Camping : Szallashely
    {
        bool vizpartiE;

        public bool VizpartiE { get => vizpartiE; }

        public Camping(bool vizpartiE, string? id, Fajta fajta, Cim cim) : base(id, fajta, cim)
        {
            this.vizpartiE = vizpartiE;
        }

        public double Arszamitas()
        {
            if (vizpartiE)
            {
                return 5000;
            }
            return 3000;
        }

        private string Vizparti()
        {
            if (vizpartiE)
            {
                return "Vízparti";
            }
            return "Nem vízparti";
        }

        public override string ToString()
        {
            return $"Camping: [{Id}] - Fajta: {Fajta} ({Cim.Iranyitoszam} {Cim.Varos} {Cim.Utca} {Cim.Hazszam}) - {Vizparti()}";
        }
    }
}
