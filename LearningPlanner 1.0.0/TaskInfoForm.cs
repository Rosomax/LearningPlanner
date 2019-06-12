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

        TaskForm currentForm;
        internal TaskForm LoadOrders(TaskForm  task)
        {
            currentForm = task;
            return currentForm;
        }

        CompletedTasksForm currentForm2;
        internal CompletedTasksForm LoadOrders(CompletedTasksForm task)
        {
            currentForm2= task;
            return currentForm2;
        }

        public string GetFinishData { get; set; }

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
                GetFinishData = DateTime.Now.ToString();

                currentForm.RefreshGrid();
                this.Close();
            }
         
               

        }
        
        public void HideButton()
        {
            FinishTask.Hide();
            EditTask.Show();
        }

        private void EditTask_Click(object sender, EventArgs e)
        {


            descriptionInfoRichTextBox.ReadOnly = false;
            using (EntitiesModel2 mod = new EntitiesModel2())
            {
                descriptionInfoRichTextBox.TextChanged += DescriptionInfoRichTextBox_TextChanged;
                var x = descriptionInfoRichTextBox.Text;
              var y = mod.Zadania.Single(u => u.IDZadania == CompletedTasksForm.Id);
                y.Opis = descriptionInfoRichTextBox.Text;

                
                mod.SaveChanges();
                
            }
            EditTask.Click += EditTask_Click1;
            this.Text = ("Szczególy zadania [Tryb edytowania]");
        }

        private void EditTask_Click1(object sender, EventArgs e)
        {
            descriptionInfoRichTextBox.ReadOnly = true;                      
            MessageBox.Show("Zaktualizowano opis");
            EditTask.Click -= EditTask_Click1;
            EditTask.Text = "Edytuj";
            this.Text = ("Szczególy zadania");
            currentForm2.RefreshGrid();
        }

        private void DescriptionInfoRichTextBox_TextChanged(object sender, EventArgs e)
        {
            EditTask.Text = "Zapisz";
        }
    }
}
