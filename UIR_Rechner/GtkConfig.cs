using System;
using System.Collections.Generic;
using System.Text;
using Gtk;

namespace UIR_Rechner
{
    class GtkConfig : Window
    {
        public static Label labelResult = new Label();
        public static CalculatorRCurrentCorrect calculator = new CalculatorRCurrentCorrect();

        public static Entry entryU = new Entry();
        public static Entry entryI = new Entry();
        public static Entry entryRi = new Entry();

        public GtkConfig() : base("Elektrotechnik Rechner")
        {
            SetDefaultSize(650, 600);
            SetPosition(WindowPosition.Center);

            Button button = new Button();
            button.Label = "Result";
            button.CheckResize();

            Label labelU = new Label("Spannung:");
            Label labelI = new Label("Strom:");
            Label labelRi = new Label("Innenwiderstand:");

            DeleteEvent += closeWindow;
            

            labelResult.Text = Convert.ToString(calculator.Result);

            Fixed fix = new Fixed();
            fix.Put(labelU, 60, 80);
            fix.Put(entryU, 60, 100);

            fix.Put(labelI, 250, 80);
            fix.Put(entryI, 250, 100);

            fix.Put(labelRi, 440, 80);
            fix.Put(entryRi, 440, 100);

            fix.Put(button, 250, 160);
            fix.Put(labelResult, 280, 200);

            Add(fix);

            ShowAll();
        }

        private void closeWindow(object o, DeleteEventArgs args)
        {
            Application.Quit();
        }

        private void calculateR(object sender, EventArgs e)
        {
            double U = 0.0;
            double I = 0.0;
            double Ri = 0.0;

            bool uBool = double.TryParse(entryU.Text, out U);
            bool iBool = double.TryParse(entryU.Text, out I);
            bool riBool = double.TryParse(entryU.Text, out Ri);

            if (uBool && iBool && riBool )
            {
                calculator.U = Convert.ToDouble(entryU.Text);
                calculator.I = Convert.ToDouble(entryI.Text);
                calculator.Ri = Convert.ToDouble(entryRi.Text);

                calculator.rCalculator();
            }

            labelResult.Text = Convert.ToString(calculator.Result);
        }
    }
}
