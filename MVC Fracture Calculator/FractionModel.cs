using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Fracture_Calculator
{
    public class FractionModel
    {
        public Fraction Fraction1 { get; set; }
        public Fraction Fraction2 { get; set; }
        public Fraction Result { get; set; }

        public void Multiply()
        {
            Result = Fraction1 * Fraction2;
        }

        public void Divide()
        {
            Result = Fraction1 / Fraction2;
        }
    }

   
}
