using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Fracture_Calculator
{
    public class FractionView
    {
        private FractionModel _model;

        public FractionView(FractionModel model)
        {
            _model = model;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"Result: {_model.Result.Numerator}/{_model.Result.Denominator}");
        }
    }
}
