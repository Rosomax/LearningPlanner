using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LearningPlanner.Properties;
namespace LearningPlanner
{
    public partial class FindTaskForm : Form
    {
        public FindTaskForm()
        {           
            InitializeComponent();
        }
       private readonly int IDUser = MainForm.UserID;
       LearningPlannerDataBaseEntities model = new LearningPlannerDataBaseEntities();

        private void FindTaskForm_Load(object sender, EventArgs e)
        {

            BackColor = Color.FromArgb(Settings.Default.RValue, Settings.Default.GValue, Settings.Default.BValue);

            FindTaskDataGrid.DataSource = model.Tasks.Select(h => new
            {
                h.IDZadania,
                h.Nazwa,
                h.Kategoria,
                h.Opis,
                h.DataUtworzenia,
                h.CzyZakonczone,
                h.IDUzytkownika
            }).
            Where(h => h.IDUzytkownika == IDUser).ToList();
            
            FindTaskDataGrid.Columns["IDZadania"].Visible = false;
            FindTaskDataGrid.Columns["IDuzytkownika"].Visible = false;     
        }

        private void FindTaskForm_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width<=799)
            {
                DefaultResponsives dresp = new DefaultResponsives();             
                    dresp.FindTaskDefaultResponse(this);                                
            }
            else
            {
                Responsiveness resp = new Responsiveness();
                resp.FindTaskResponse(this);
            }
        }

        public void FillGrid()
        {
            FindTaskDataGrid.DataSource = model.Tasks.Select(o => new
            {
                o.IDZadania,
                o.Nazwa,
                o.Kategoria,
                o.Opis,
                o.DataUtworzenia,
                o.CzyZakonczone,
                o.IDUzytkownika
            }).Where(o => o.IDUzytkownika == IDUser).ToList();
        }

        private void FindTaskTextBox_TextChanged(object sender, EventArgs e)
        {
            string findText = FindTaskTextBox.Text;

            if (FilterComboBox.SelectedIndex == 0)
            {
                FindTaskDataGrid.DataSource = model.Tasks.Select(h => new
                {
                    h.IDZadania,
                    h.Nazwa,
                    h.Kategoria,
                    h.Opis,
                    h.DataUtworzenia,
                    h.CzyZakonczone,
                    h.IDUzytkownika
                }).
                Where(h => h.IDUzytkownika == IDUser).Where(h => DbFunctions.TruncateTime(h.DataUtworzenia)
                >= FilterFrom.Value.Date && DbFunctions.TruncateTime(h.DataUtworzenia) <= FilterTo.Value.Date)
                .Where(h => h.Nazwa.StartsWith(findText)).ToList();               
            }

            else if (FilterComboBox.SelectedIndex == 1)
            {
                FindTaskDataGrid.DataSource = model.Tasks.Select(h => new
                {
                    h.IDZadania,
                    h.Nazwa,
                    h.Kategoria,
                    h.Opis,
                    h.DataUtworzenia,
                    h.CzyZakonczone,
                    h.IDUzytkownika
                }).
               Where(h => h.IDUzytkownika == IDUser).Where(h => DbFunctions.TruncateTime(h.DataUtworzenia)
                >= FilterFrom.Value.Date && DbFunctions.TruncateTime(h.DataUtworzenia) <= FilterTo.Value.Date)
                .Where(h => h.Opis.StartsWith(findText)).ToList();
              
            }

            else if (FilterComboBox.SelectedIndex == 2)
            {
                FindTaskDataGrid.DataSource = model.Tasks.Select(h => new
                {
                    h.IDZadania,
                    h.Nazwa,
                    h.Kategoria,
                    h.Opis,
                    h.DataUtworzenia,
                    h.CzyZakonczone,
                    h.IDUzytkownika
                }).
               Where(h => h.IDUzytkownika == IDUser).Where(h => DbFunctions.TruncateTime(h.DataUtworzenia)
                >= FilterFrom.Value.Date && DbFunctions.TruncateTime(h.DataUtworzenia) <= FilterTo.Value.Date)
                .Where(h => h.Kategoria.StartsWith(findText)).ToList();       
            }


            else
                FindTaskDataGrid.DataSource = model.Tasks.Select(h => new
                {
                    h.IDZadania,
                    h.Nazwa,
                    h.Kategoria,
                    h.Opis,
                    h.DataUtworzenia,
                    h.CzyZakonczone,
                    h.IDUzytkownika
                }).
                Where(h => h.IDUzytkownika == IDUser).Where(h => DbFunctions.TruncateTime(h.DataUtworzenia)
                >= FilterFrom.Value.Date && DbFunctions.TruncateTime(h.DataUtworzenia) <= FilterTo.Value.Date)
                .Where(h => h.Nazwa.StartsWith(findText)).ToList();        
        }
       
        private void FilterFrom_ValueChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
    
        public DataGridViewRow SelectedRow { get; private set; }
        public bool Status { get; private set; }
        public static int Id { get; private set; }

        private void FindTaskDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (FindTaskDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = FindTaskDataGrid.SelectedCells[0].RowIndex;
                SelectedRow = FindTaskDataGrid.Rows[selectedrowindex];

                var creationDate = DateTime.Now;
                Id = Convert.ToInt32(SelectedRow.Cells["IDZadania"].Value);
                string name = Convert.ToString(SelectedRow.Cells["Nazwa"].Value);
                string category = Convert.ToString(SelectedRow.Cells["Kategoria"].Value);
                string description = Convert.ToString(SelectedRow.Cells["Opis"].Value);
                creationDate = Convert.ToDateTime(SelectedRow.Cells["DataUtworzenia"].Value);
                Status = Convert.ToBoolean(SelectedRow.Cells["CzyZakonczone"].Value);

                TaskInfoForm frm = new TaskInfoForm();
                frm.HideAllButtons();
                frm.SetDoubleClickInfo(name, category, description, creationDate);
                frm.Show();


                if (Status)               
                    frm.StatusInfoLabel1.Text = "Zakończono";                          
                else
                    frm.StatusInfoLabel1.Text = "Nie zakończono";
            }

        }
                  
    }

}







