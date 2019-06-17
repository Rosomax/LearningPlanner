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
            describeTaskLabel.Visible = false;
            describeTaskRichTextBox.Visible = false;

            chooseCategoryDataGrid.DataSource = categoryModel.Zadania.Select(c => new
            {
                c.Kategoria,
                c.IDUzytkownika

            }).Where(c => c.IDUzytkownika == IDUser).Distinct().ToList();
            chooseCategoryDataGrid.Columns["IDUzytkownika"].Visible = false;


        }


        private void chooseCategoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string activeCell = chooseCategoryDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();


                chooseTaskLabel.Visible = true;
                chooseTaskDataGrid.Visible = true;
                describeTaskLabel.Visible = false;
                describeTaskRichTextBox.Visible = false;
                chooseTaskDataGrid.DataSource = categoryModel.Zadania.Select(t => new
                {
                    t.Nazwa,
                    t.Kategoria,
                    t.IDUzytkownika
                }).Where(t => t.Kategoria == activeCell).Where(t => t.IDUzytkownika == IDUser).ToList();
            }
            catch
            {

            }





            chooseTaskDataGrid.Columns["Kategoria"].Visible = false;
            chooseTaskDataGrid.Columns["IDUzytkownika"].Visible = false;
        }

        public string GetDescribe(string activeCell)
        {
          
            return (from Zadania in categoryModel.Zadania
                    where Zadania.Nazwa.Equals(activeCell)
                    select Zadania.Opis).SingleOrDefault().ToString();
        }

        private void chooseTaskDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string activeCell = chooseTaskDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                describeTaskLabel.Visible = true;
                describeTaskRichTextBox.Visible = true;
                describeTaskRichTextBox.Text = GetDescribe(activeCell);
            }
            catch { }
        }

        private void CategoryForm_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width <= 799)
            {
                chooseCategoryLabel.Size = new Size(184,23);
                chooseCategoryLabel.Location = new Point(12,9);
                chooseCategoryLabel.Font = new Font("Centhury Gothic", 14);
                chooseTaskLabel.Size = new Size(170,23);
                chooseTaskLabel.Location = new Point(248,9);
                chooseTaskLabel.Font = new Font("Centhury Gothic", 14);
                describeTaskLabel.Size = new Size(140,23);
                describeTaskLabel.Location = new Point(498,9);
                describeTaskLabel.Font = new Font("Centhury Gothic", 14);
                chooseCategoryDataGrid.Size = new Size(180,453);
                chooseCategoryDataGrid.Location = new Point(16,35);
                chooseCategoryDataGrid.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                chooseTaskDataGrid.Size = new Size(180, 453);
                chooseTaskDataGrid.Location = new Point(252,35);
                chooseTaskDataGrid.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                describeTaskRichTextBox.Size = new Size(166,453);
                describeTaskRichTextBox.Location = new Point(502,35);
                describeTaskRichTextBox.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            }
            else if (Size.Width >= 800)
            {
                chooseCategoryLabel.Size = new Size(384, 63);
                chooseCategoryLabel.Location = new Point(112, 9);
                chooseCategoryLabel.Font = new Font("Centhury Gothic", 22);
                chooseTaskLabel.Size = new Size(384, 63);
                chooseTaskLabel.Location = new Point(648, 9);
                chooseTaskLabel.Font = new Font("Centhury Gothic", 22);
                describeTaskLabel.Size = new Size(384, 63);
                describeTaskLabel.Location = new Point(1198, 9);
                describeTaskLabel.Font = new Font("Centhury Gothic", 22);
                chooseCategoryDataGrid.Size = new Size(384, 853);
                chooseCategoryDataGrid.Location = new Point(116, 75);
                chooseCategoryDataGrid.Font = new Font("Century Gothic", 20, FontStyle.Bold);
               // chooseCategoryDataGrid.RowsDefaultCellStyle.Font= new Font("Century Gothic", 20, FontStyle.Bold);
                chooseTaskDataGrid.Size = new Size(384, 853);
                chooseTaskDataGrid.Location = new Point(648, 75);
                chooseTaskDataGrid.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                describeTaskRichTextBox.Size = new Size(384, 853);
                describeTaskRichTextBox.Location = new Point(1198,75);
                describeTaskRichTextBox.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            }
        }
    }
}
