using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    public partial class TaskInfoForm : Form
    {
        public TaskInfoForm()
        {
            InitializeComponent();         
        }
       

      
       public void SetDoubleClickInfo(string nazw, string kat, string opis, DateTime dataUtw ,string status)
        {
            
            nameInfoLbl1.Text = nazw;
            categoryInfoLbl1.Text = kat;
            descriptionInfoRichTextBox.Text = opis;
            creationDateInfoLbl1.Text = dataUtw.ToString();
            statusInfoLbl1.Text = status;

        }

        private void TaskInfoForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(138, 197, 222);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            middlePanelInfo.BackColor = Color.FromArgb(178, 8, 55);
            

        }
    }
}
