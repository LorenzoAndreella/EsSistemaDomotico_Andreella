using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EsSistemaDomotico
{
    internal class CLampadina : DispositivoSmart
    {
        public double Luminosita { get; set; }

        public CLampadina(string nome, string stanza, double luminosita) : base(nome, stanza)
        {
            Luminosita = luminosita;
        }
        public override string MostraDettagli()
        {
            return $"Lampadina: {Nome}, Stanza: {Stanza} Acceso: {IsAcceso}, Luminosità: {Luminosita}";
        }

    }
}
