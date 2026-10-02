using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSistemaDomotico
{
    internal class CAllarme : ISwitchable
    {
        private bool isAcceso;
        public bool IsAcceso
        {
            get { return isAcceso; }
        }
        public CAllarme()
        {
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
    }
}
