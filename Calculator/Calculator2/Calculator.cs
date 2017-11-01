using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Calculator : CalculatorMusthaves
    {
        public int Diff(int getal1, int getal2)
        {
            return getal1 - getal2;

        }

        public int Product(int getal1, int getal2)
        {
            return getal1 * getal2;
        }

        public int Quotient(int getal1, int getal2)
        {
            return getal1 / getal2; ;
        }

        public int Sum(int getal1, int getal2)
        {
            // datatype + variabele naam = | niet verplicht
            int sum = getal1 + getal2;

            return sum;
        }
    }
}
