using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Fracture_Calculator
{
    public class FractionController
    {
        private FractionModel _model;
        private FractionView _view;

        public FractionController(FractionModel model, FractionView view)
        {
            _model = model;
            _view = view;
        }

        public void Multiply()
        {
            _model.Multiply();
            _view.DisplayResult();
        }

        public void Divide()
        {
            _model.Divide();
            _view.DisplayResult();
        }
    }
}
