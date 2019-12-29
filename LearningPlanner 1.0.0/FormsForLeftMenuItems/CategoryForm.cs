using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LearningPlanner.Properties;

namespace LearningPlanner
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

       private readonly int IDUser = MainForm.UserID;

        LearningPlannerDataBaseEntities categoryModel = new LearningPlannerDataBaseEntities();

        private void Category_Load(object sender, EventArgs e)
        {

            BackColor = Color.FromArgb(Settings.Default.RValue, Settings.Default.GValue, Settings.Default.BValue);
            
            chooseCategoryDataGrid.DataSource = categoryModel.Tasks.Select(c => new
            {
                c.Kategoria,
                c.IDUzytkownika

            }).Where(c => c.IDUzytkownika == IDUser).Distinct().ToList();
            chooseCategoryDataGrid.Columns["IDUzytkownika"].Visible = false;

        }

        private void CategoryForm_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width <= 799)
            {
                DefaultResponsives dresp = new DefaultResponsives();              
                dresp.CategoryFormDefaultResponse(this);
            }
            else
            {
                Responsiveness resp = new Responsiveness();          
                    resp.CategoryResponse(this);
            }
        }

        #region GridHandlers

        private void ChooseCategoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string activeCategoryCell = chooseCategoryDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();


                chooseTaskLabel.Visible = true;
                chooseTaskDataGrid.Visible = true;
                describeTaskLabel.Visible = false;
                describeTaskRichTextBox.Visible = false;
                chooseTaskDataGrid.DataSource = categoryModel.Tasks.Select(t => new
                {
                    t.Nazwa,
                    t.Kategoria,
                    t.IDUzytkownika
                }).Where(t => t.Kategoria == activeCategoryCell).Where(t => t.IDUzytkownika == IDUser).ToList();

                chooseTaskDataGrid.Columns["Kategoria"].Visible = false;
                chooseTaskDataGrid.Columns["IDUzytkownika"].Visible = false;
            }
            catch
            {

            }

        }
    

        private void ChooseTaskDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string activeTaskCell = chooseTaskDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                describeTaskLabel.Visible = true;
                describeTaskRichTextBox.Visible = true;
                describeTaskRichTextBox.Text = GetDescribe(activeTaskCell);
            }
            catch { }
        }

        public string GetDescribe(string activeCell)
        {

            return (from Tasks in categoryModel.Tasks
                    where Tasks.Nazwa.Equals(activeCell)
                    select Tasks.Opis).SingleOrDefault().ToString();
        }

        #endregion

    }
}
