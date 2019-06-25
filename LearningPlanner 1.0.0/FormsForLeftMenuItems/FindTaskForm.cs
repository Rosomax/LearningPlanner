using System;
using System.Collections.Generic;
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

        EntitiesModel model = new EntitiesModel();


        private void FindTaskForm_Load(object sender, EventArgs e)
        {
            FindTaskFormChangeFont();

            BackColor = Color.FromArgb(Settings.Default.RValue, Settings.Default.GValue, Settings.Default.BValue);
            

            FindTaskDataGrid.DataSource = model.Zadania.Select(h => new
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

            // Ukrycie kolumn
            FindTaskDataGrid.Columns["IDZadania"].Visible = false;
            FindTaskDataGrid.Columns["IDuzytkownika"].Visible = false;


           
        }

        private void FindTaskForm_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width <= 799)
            {

                FindTaskDataGrid.Size = new Size(450, 500);
                FindTaskDataGrid.RowsDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                FindTaskLabel.Size = new Size(186, 19);
                FindTaskLabel.Location = new Point(24, 39);
                FindTaskLabel.Font = new Font("Century Gothic", 12);
                FindTaskTextBox.Size = new Size(192, 200);
                FindTaskTextBox.Location = new Point(28, 61);
                FindTaskTextBox.Font = new Font("Century Gothic", 8);
                FilterLabel.Size = new Size(38, 19);
                FilterLabel.Location = new Point(24, 113);
                FilterLabel.Font = new Font("Century Gothic", 12);
                FilterComboBox.Size = new Size(192, 21);
                FilterComboBox.Location = new Point(28, 135);
                FilterComboBox.Font = new Font("Century Gothic", 8);
                FilterFromLabel.Size = new Size(77, 19);
                FilterFromLabel.Location = new Point(8, 188);
                FilterFromLabel.Font = new Font("Century Gothic", 12);
                FilterFrom.Size = new Size(232, 22);
                FilterFrom.Location = new Point(12, 210);
                FilterFrom.Font = new Font("Century Gothic", 9);
                FilterToLabel.Size = new Size(77, 19);
                FilterToLabel.Location = new Point(8, 243);
                FilterToLabel.Font = new Font("Century Gothic", 12);
                FilterTo.Size = new Size(232, 22);
                FilterTo.Location = new Point(12, 265);
                FilterTo.Font = new Font("Century Gothic", 9);
                FindPictureBox.Size = new Size(176, 99);
                FindPictureBox.Location = new Point(44, 358);
            }
            else
            {
                Responsiveness resp = new Responsiveness();
                resp.FindTaskResponse(this);

            }
        }

        public void FillGrid()
        {
            FindTaskDataGrid.DataSource = model.Zadania.Select(o => new
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
                FindTaskDataGrid.DataSource = model.Zadania.Select(h => new
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
                FindTaskDataGrid.DataSource = model.Zadania.Select(h => new
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
                FindTaskDataGrid.DataSource = model.Zadania.Select(h => new
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
                FindTaskDataGrid.DataSource = model.Zadania.Select(h => new
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
       
        #region ChangeFontFromSettings
     

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
       

        public void FindTaskFormChangeFont()
        {

            string font = Settings.Default.RememberFont;
            bool boldFont = Settings.Default.BoldFont;

            foreach (var lbl in GetAll(this, typeof(Label)))
            {
                if (boldFont)
                    (lbl as Label).Font = new Font(font, 12, FontStyle.Bold);
                else
                    (lbl as Label).Font = new Font(font, 12);

            }

            foreach (var grid in GetAll(this, typeof(DataGridView)))
            {
                if (boldFont)
                    (grid as DataGridView).Font = new Font(font, 8, FontStyle.Bold);
                else
                    (grid as DataGridView).Font = new Font(font, 8);
            }

        }

        #endregion

    }

}







