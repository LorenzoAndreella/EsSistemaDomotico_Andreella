using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSistemaDomotico
{
    abstract class DispositivoSmart : ISwitchable
    {
        private bool isAcceso;
        protected string Nome { get; set; }
        protected string Stanza { get; set; }
        public bool IsAcceso
        {
            get { return isAcceso; }
        }

        public DispositivoSmart(string nome, string stanza)
        {
            Nome = nome;
            Stanza = stanza;
            isAcceso = false;
        }

        public void Accendi()
        {
            isAcceso = true;
        }
        public void Spegni()
        {
            isAcceso = false;
        }
        public abstract string MostraDettagli();
        

    }
}
