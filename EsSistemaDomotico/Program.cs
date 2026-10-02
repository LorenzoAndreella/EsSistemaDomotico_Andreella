using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSistemaDomotico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> dispositivi = new List<ISwitchable>();
            CTermostato termostato = new CTermostato("Termostato1", "Soggiorno", 20);
            CLampadina lampadina = new CLampadina("Lampadina1", "Cucina", 80);
            CAllarme allarme = new CAllarme();
            dispositivi.Add(termostato);
            dispositivi.Add(lampadina);
            dispositivi.Add(allarme);

            foreach (var dispositivo in dispositivi)
            {
                dispositivo.Accendi();
                if (dispositivo is DispositivoSmart smart)
                {
                    Console.WriteLine(smart.MostraDettagli());
                }
            }
        }
    }
}
