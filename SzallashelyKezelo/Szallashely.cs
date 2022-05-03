using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzallashelyKezelo
{
    enum Fajta
    {
        üzleti,
        sport,
        gyógy,
        egyéb
    }

    abstract class Szallashely
    {
        string? id;
        Fajta fajta;
        Cim cim;

        public string? Id 
        {
            get => id; 
            set
            {
                if (value.Length == 8)
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Az azonosító pontosan 8 karakter lehet!");
                }
            }
        }
        internal Fajta Fajta { get => fajta; }
        internal Cim Cim { get => cim; }

        public Szallashely(string id, Fajta fajta, Cim cim )
        {
            this.fajta = fajta;
            this.cim = cim;
            Id = id;
        }
    }

    class Cim
    {
        string iranyitoszam;
        string varos;
        string utca;
        string hazszam;

        public string Iranyitoszam 
        { 
            get => iranyitoszam;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    iranyitoszam = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Az irányítószám 1000 és 9999 közé kell, hogy essen!");
                }
            }
        }
        public string Varos
        { 
            get => varos;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    varos = value;
                }
                else
                {
                    throw new Exception("A város mező nem lehet üres!");
                }
            }
        }
        public string Utca
        { 
            get => utca;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    utca = value;
                }
                else
                {
                    throw new Exception("Az utca mező nem lehet üres!");
                }
            } 
        }
        public string Hazszam { get => hazszam; }

        public Cim(string iranyitoszam, string varos, string utca, string hazszam)
        {
            Iranyitoszam = iranyitoszam;
            Varos = varos;
            Utca = utca;
            this.hazszam = hazszam;
        }
    }
}
