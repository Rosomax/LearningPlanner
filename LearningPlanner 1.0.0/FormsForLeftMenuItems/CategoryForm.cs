using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LearningPlanner_1._0._0.Properties;
namespace LearningPlanner_1._0._0
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        int IDUser = MainForm.UserID;
        EntitiesModel2 categoryModel = new EntitiesModel2();

        private void Category_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Settings.Default.track1, Settings.Default.track2, Settings.Default.track3);
            chooseTaskLabel.Visible = false;
            chooseTaskDataGrid.Visible = false;

            chooseCategoryDataGrid.DataSource = categoryModel.Zadania.Select(c => new
            {
                c.Kategoria,
                c.IDUzytkownika

            }).Where(c => c.IDUzytkownika == IDUser).ToList();
            chooseCategoryDataGrid.Columns["IDUzytkownika"].Visible = false;

            
        }
        

        private void chooseCategoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string activeCell = chooseCategoryDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            
            chooseTaskLabel.Visible = true;
            chooseTaskDataGrid.Visible = true;

            chooseTaskDataGrid.DataSource = categoryModel.Zadania.Select(t => new
            {
                t.Nazwa,
                t.Kategoria,
                t.IDUzytkownika
            }).Where(t => t.Kategoria == activeCell).Distinct().Where(t => t.IDUzytkownika == IDUser).ToList();

            


            chooseTaskDataGrid.Columns["Kategoria"].Visible = false;
            chooseTaskDataGrid.Columns["IDUzytkownika"].Visible = false;
        }
    }
}
