using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ex01.ApplicationUI;
using FacebookWrapper;

namespace Ex01.ApplicationUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
