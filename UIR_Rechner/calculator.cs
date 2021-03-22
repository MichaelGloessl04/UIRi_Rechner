using System;
using System.Collections.Generic;
using System.Text;

namespace UIR_Rechner
{
    class calculator
    {
        private double _R = 0.0;
        private double _U = 0.0;
        private double _I = 0.0;

        public double getSetR
        {
            get => _R;
            set
            {
                _R = value;
            }
        }

        public double getSetU
        {
            get => _U;
            set
            {
                _U = value;
            }
        }

        public double getSetI
        {
            get => _I;
            set
            {
                _I = value;
            }
        }


    }
}
