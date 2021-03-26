using System;
using System.Collections.Generic;
using System.Text;

namespace UIR_Rechner
{
    class CalculatorRCurrentCorrect
    {
        private double _Ri = 0.0;
        private double _U = 0.0;
        private double _I = 0.0;
        private double _Result = 0.0;

        public double Ri
        {
            get { return _Ri; }
            set
            {
                _Ri = value;
            }
        }

        public double U
        {
            get => _U;
            set
            {
                _U = value;
            }
        }

        public double I
        {
            get => _I;
            set
            {
                _I = value;
            }
        }

        public double Result
        {
            get => _Result;
            set
            {
                _Result = value;
            }
        }

        public void rCalculator()
        {
            double Rges = U / I;

            Result = Math.Round((Rges - Ri),2);
        }
    }
}
