using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
namespace LearningPlanner_1._0._0
{
    public partial class TaskInfoForm : Form
    {
        public TaskInfoForm()
        {
            InitializeComponent();         
        }

      
        public void SetDoubleClickInfo(string nazw, string kat, string opis, DateTime dataUtw)
        {
            
            nameInfoLbl1.Text = nazw;
            categoryInfoLbl1.Text = kat;
            descriptionInfoRichTextBox.Text = opis;
            creationDateInfoLbl1.Text = dataUtw.ToString();
        }

        private void TaskInfoForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(138, 197, 222);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            middlePanelInfo.BackColor = Color.FromArgb(178, 8, 55);
           
        }
       



        private void FinishTask_Click(object sender, EventArgs e)
        {
          if  (MessageBox.Show("Czy napewno chcesz zakończyć to zadanie?","Koniec zadania", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var y = TaskForm.Id;

                using (EntitiesModel2 mod = new EntitiesModel2())
                {
                    var x = mod.Zadania.Single(z => z.IDZadania == y);
                    x.CzyZakonczone = true;
                    mod.SaveChanges();
                    
                   

                    
                }
                









            }
        }
    }
}
