using System;
using Gtk;

namespace metasource_feb2020
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            
            Application.Run();
        }
    }
}
