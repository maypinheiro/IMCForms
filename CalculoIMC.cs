using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCForms
{
    public  class CalculoIMC
    {

        public  double IMC(double peso, double altura)
        {
           double imc = peso / (altura * altura);
            return imc;
        }

    }
}
