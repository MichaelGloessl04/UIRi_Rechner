using System;
using Gtk;

namespace UIR_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();
            new GtkConfig();
            Application.Run();
        } 
    }
}
