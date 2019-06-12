using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    public partial class FindTaskForm : Form
    {
        public FindTaskForm()
        {
            InitializeComponent();
        }
        int IDUser = MainForm.UserID;
        EntitiesModel2 findmodel;


        private void FindTaskForm_Load(object sender, EventArgs e)
        {


            this.BackColor = Color.FromArgb(138, 197, 222);
            FindTaskDataGrid.DefaultCellStyle.ForeColor = Color.FromArgb(178, 8, 55);

            findmodel = new EntitiesModel2();
            FindTaskDataGrid.DataSource = findmodel.Zadania.Select(h => new
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

        private void FindTaskButton_Click(object sender, EventArgs e)
        {
            string FindText = FindTaskTextBox.Text;
            findmodel = new EntitiesModel2();
            FindTaskDataGrid.DataSource = findmodel.Zadania.Select(h => new
            {
                h.IDZadania,
                h.Nazwa,
                h.Kategoria,
                h.Opis,
                h.DataUtworzenia,
                h.CzyZakonczone,
                h.IDUzytkownika
            }).
            Where(h => h.IDUzytkownika == IDUser).Where(h => h.Nazwa.StartsWith(FindText)).ToList();


        }

        private void FindTaskTextBox_TextChanged(object sender, EventArgs e)
        {
            string FindText = FindTaskTextBox.Text;




            findmodel = new EntitiesModel2();
            if (filterComboBox.SelectedIndex == 0)
            {
                FindTaskDataGrid.DataSource = findmodel.Zadania.Select(h => new
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
                >= filterFrom.Value.Date && DbFunctions.TruncateTime(h.DataUtworzenia) <= filterTo.Value.Date)
                .Where(h => h.Nazwa.StartsWith(FindText)).ToList();





            }
            else if (filterComboBox.SelectedIndex == 1)
            {
                FindTaskDataGrid.DataSource = findmodel.Zadania.Select(h => new
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
                >= filterFrom.Value.Date && DbFunctions.TruncateTime(h.DataUtworzenia) <= filterTo.Value.Date)
                .Where(h => h.Opis.StartsWith(FindText)).ToList();
            }
            else if (filterComboBox.SelectedIndex == 2)
            {
                FindTaskDataGrid.DataSource = findmodel.Zadania.Select(h => new
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
                >= filterFrom.Value.Date && DbFunctions.TruncateTime(h.DataUtworzenia) <= filterTo.Value.Date)
                .Where(h => h.Kategoria.StartsWith(FindText)).ToList();

            }


            else
                FindTaskDataGrid.DataSource = findmodel.Zadania.Select(h => new
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
                >= filterFrom.Value.Date && DbFunctions.TruncateTime(h.DataUtworzenia) <= filterTo.Value.Date)
                .Where(h => h.Nazwa.StartsWith(FindText)).ToList();
        }

        public void RefreshGrid()
        {
            FindTaskDataGrid.DataSource = findmodel.Zadania.Select(o => new
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


        private void FilterFrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void FindTaskForm_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width <= 799)
            {
                FindTaskDataGrid.Size = new Size(450, 500);

            }
            else if (Size.Width >= 800)
            {

                FindTaskDataGrid.Size = new Size(700, 404);
            }
        }

    }

}







