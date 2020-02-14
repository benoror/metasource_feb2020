using System;
using System.Collections.Generic;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnInputChanged(object sender, EventArgs e)
    {
        output.Text = commonLowerChar(input.Text.ToString());
    }

    public static string commonLowerChar(string s)
    {
        if (s.Length < 1) return "";

        Dictionary<char, int> counterIndex = new Dictionary<char, int>();
        int maxCount = 0;
        char maxChar = ' ';

        foreach (char c in s)
        {
            if (char.IsLower(c))
            {
                if (counterIndex.ContainsKey(c))
                {
                    counterIndex[c]++;
                }
                else
                {
                    counterIndex.Add(c, 1);
                }

                if (counterIndex[c] > maxCount)
                {
                    maxCount = counterIndex[c];
                    maxChar = c;
                }
            }
        }

        return maxChar + " " + counterIndex[maxChar];
    }
}
