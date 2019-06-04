using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Timer = System.Windows.Forms.Timer;

namespace LearningPlanner_1._0._0
{
    public partial class IntroForm1 : Form
    {
        public IntroForm1()
        {
            InitializeComponent();
           
            CreateTimer();
        }

        private void Statystyki()
        {
            var dateStart = DateTime.Now.ToString();
            var netBIOS = System.Environment.MachineName.ToString();
            var physicalMemory = System.Environment.WorkingSet.ToString();
            var loggedUserName = System.Environment.UserName.ToString();
            

            if (File.Exists("LocalLogs.txt"))
                using (StreamWriter write = new StreamWriter("LocalLogs.txt", true))
                {
                    write.WriteLine($"start: {dateStart} username: {loggedUserName} NetBIOS: {netBIOS} physical memory:" +
                        $" {physicalMemory}  ");

                }
            else
                using (StreamWriter write = new StreamWriter("LocalLogs.txt", false))
                {
                    write.WriteLine();

                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            Thread t = new Thread(new ThreadStart(Statystyki));
            t.Start();

            this.Close();           
        }

       private void CreateTimer()
        {
            Timer t1 = new Timer();
            t1.Interval = 500;
            t1.Tick += T1_Tick;
            this.Invalidate();
            t1.Start();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            button1.Visible = true;
            this.Invalidate();
            
        }
    }
}
