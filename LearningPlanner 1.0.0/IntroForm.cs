using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Timer = System.Windows.Forms.Timer;

namespace LearningPlanner
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
           
            CreateTimer();
        }

        private void SystemLog()
        {
            var dateStart = DateTime.Now.ToString();
            var netBIOS = System.Environment.MachineName.ToString();
            var physicalMemory = System.Environment.WorkingSet.ToString();
            var loggedUserName = System.Environment.UserName.ToString();

            string path = "Logs\\LocalLogs.txt";

            if (File.Exists(path))
                using (StreamWriter write = new StreamWriter(path, true))
                {
                    write.WriteLine($"start: {dateStart} username: {loggedUserName} NetBIOS: {netBIOS} physical memory:" +
                        $" {physicalMemory}  ");
                    
                }
            else
                using (StreamWriter write = new StreamWriter(path, false))
                {
                    write.WriteLine();
                   
                }

            

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
       
            Thread t = new Thread(new ThreadStart(SystemLog));
            t.Start();

            Close();           
        }

       private void CreateTimer()
        {
            Timer t1 = new Timer
            {
                Interval = 500
            };
            t1.Tick += T1_Tick;
            Invalidate();
            t1.Start();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            OkButton.Visible = true;
            Invalidate();
            
        }
    }
}
