using System;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IntroForm1());
            Application.Run(new MainForm());
            
        }
    }
}
