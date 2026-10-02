using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSistemaDomotico
{
    internal class CTermostato : DispositivoSmart
    {
        public double Temperatura { get; set; }
        public CTermostato(string nome, string stanza, double temperatura) : base(nome, stanza)
        {
            Temperatura = temperatura;
        }
        public override string MostraDettagli()
        {
            return $"Termostato: {Nome}, Stanza: {Stanza} Acceso: {IsAcceso}, Temperatura: {Temperatura}";
        }

    }
}
