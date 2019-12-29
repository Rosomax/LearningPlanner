using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace LearningPlanner
{
    public partial class TaskInfoForm : Form
    {
        public TaskInfoForm()
        {
            InitializeComponent();         
        }
      
        public void SetDoubleClickInfo(string nazw, string kat, string opis, DateTime dataUtw)
        {          
            NameInfoLabel1.Text = nazw;
            CategoryInfoLabel1.Text = kat;
            DescriptionInfoRichTextBox.Text = opis;
            CreatedInfoLabel1.Text = dataUtw.ToString();
        }

        private void TaskInfoForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(138, 197, 222);
            MinimizeBox = false;
            MaximizeBox = false;
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

        public string GetFinishData { get; private set; }

        private void FinishTask_Click(object sender, EventArgs e)
        {
          if  (MessageBox.Show("Czy napewno chcesz zakończyć to zadanie?","Koniec Zadania", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedRowId = TaskForm.Id;
            
                using (LearningPlannerDataBaseEntities mod = new LearningPlannerDataBaseEntities())
                {
                    var selectedTask = mod.Tasks.Single(z => z.IDZadania == selectedRowId);
                    selectedTask.CzyZakonczone = true;
                    mod.SaveChanges();
                 
                }

                GetFinishData = DateTime.Now.ToString();

                currentForm.FillGrid();
                Close();
            }
                       
        }
        
        public void HideFinishTaskButton()
        {
            FinishTaskButton.Hide();
            EditTaskButton.Show();
        }

        public void HideAllButtons()
        {
            FinishTaskButton.Hide();
            EditTaskButton.Hide();
        }

        private void EditTask_Click(object sender, EventArgs e)
        {

            DescriptionInfoRichTextBox.ReadOnly = false;
            using (LearningPlannerDataBaseEntities mod = new LearningPlannerDataBaseEntities())
            {
                DescriptionInfoRichTextBox.TextChanged += DescriptionInfoRichTextBox_TextChanged;

                var selectedRowId = mod.Tasks.Single(u => u.IDZadania == CompletedTasksForm.Id);
                selectedRowId.Opis = DescriptionInfoRichTextBox.Text;
              
                mod.SaveChanges();
                
            }
            EditTaskButton.Click += EditTask_Click1;
            Text = ("Szczególy Zadania [Tryb edytowania]");
        }

        private void EditTask_Click1(object sender, EventArgs e)
        {
            DescriptionInfoRichTextBox.ReadOnly = true;                      
            MessageBox.Show("Zaktualizowano opis");
            EditTaskButton.Click -= EditTask_Click1;
            EditTaskButton.Text = "Edytuj";
            Text = ("Szczególy Zadania");
            currentForm2.FillGrid();
        }

        private void DescriptionInfoRichTextBox_TextChanged(object sender, EventArgs e)
        {
            EditTaskButton.Text = "Zapisz";
        }
    }
}
