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

            VBox vBox1 = new VBox();
            VBox vBox2 = new VBox();
            VBox vBoxU = new VBox();
            VBox vBoxI = new VBox();
            VBox vBoxRi = new VBox();

            HBox hBox = new HBox();

            vBoxU.Add(labelU);
            vBoxU.Add(entryU);

            vBoxI.Add(labelI);
            vBoxI.Add(entryI);

            vBoxRi.Add(labelRi);
            vBoxRi.Add(entryRi);

            vBox2.Add(button);
            vBox2.Add(labelResult);

            hBox.Add(vBoxU);
            hBox.Add(vBoxI);
            hBox.Add(vBoxRi);

            vBox1.Add(hBox);
            vBox1.Add(vBox2);

            button.SetSizeRequest(80,30);

            Add(vBox1);

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
