using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSaulo
{
    class SeguroDeVida : ITributavel
    {
        private double tributo = 42;
        public double calculaTributos()
        {
            return tributo;
        }

    }
}
