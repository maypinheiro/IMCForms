using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCForms
{
   public class Resultado
    {
        public string EstadoNutricional(double imc)
        {
            if (imc < 18.5)
                return " Abaixo do Peso";
            else if (imc < 25)
                return " Peso Ideal";
            else if (imc < 30)
                return " Peso Ideal";
            else if (imc < 35)
                return " Obesidade grau I";
            else if (imc < 35)
                return " Obesidade grau II";
            else
                return "Obesidade grau III";

        }
    }
}
