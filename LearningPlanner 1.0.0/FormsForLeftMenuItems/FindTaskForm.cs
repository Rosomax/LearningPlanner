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
               // FindTaskDataGrid.DefaultCellStyle.Font = new Font("century schoolbook", 9);
                FIndTaskLabel.Size = new Size(186,19);
                FIndTaskLabel.Location = new Point(24,39);
                FIndTaskLabel.Font = new Font("Century Gothic", 12);
                FindTaskTextBox.Size =  new Size(192, 200);
                FindTaskTextBox.Location=new Point(28, 61);
                FindTaskTextBox.Font = new Font("Century Gothic", 8);
                filtrLabel.Size = new Size(38, 19);
                filtrLabel.Location = new Point(24, 113);
                filtrLabel.Font= new Font("Century Gothic", 12);
                filterComboBox.Size = new Size(192, 21);
                filterComboBox.Location = new Point(28, 135);
                filterComboBox.Font= new Font("Century Gothic", 8);
                filterFromLabel.Size = new Size(77,19);
                filterFromLabel.Location = new Point(8,188);
                filterFromLabel.Font= new Font("Century Gothic", 12);
                filterFrom.Size = new Size(232,22);
                filterFrom.Location = new Point(12,210);
                filterFrom.Font= new Font("Century Gothic", 9);
                filterToLabel.Size = new Size(77,19);
                filterToLabel.Location = new Point(8,243);
                filterToLabel.Font= new Font("Century Gothic", 12);
                filterTo.Size = new Size(232,22);
                filterTo.Location = new Point(12,265);
                filterTo.Font = new Font("Century Gothic", 9);
                findPictureBox.Size = new Size(176,99);
                findPictureBox.Location = new Point(44,358);
            }
            else if (Size.Width >= 800)
            {

                FindTaskDataGrid.Size = new Size(700, 404);
                //FindTaskDataGrid.DefaultCellStyle.Font = new Font("century schoolbook", 26);
                FIndTaskLabel.Size = new Size(286, 29);
                FIndTaskLabel.Location = new Point(200, 39);
                FIndTaskLabel.Font = new Font("Century Gothic", 32);
                FindTaskTextBox.Size = new Size(520, 300);
                FindTaskTextBox.Location = new Point(200, 100);
                FindTaskTextBox.Font= new Font("Century Gothic", 22);
                filtrLabel.Size = new Size(38, 19);
                filtrLabel.Location = new Point(200, 150);
                filtrLabel.Font= new Font("Century Gothic", 32);
                filterComboBox.Size = new Size(520, 21);
                filterComboBox.Location = new Point(200,210);
                filterComboBox.Font= new Font("Century Gothic", 22);
                filterFromLabel.Size = new Size(77, 19);
                filterFromLabel.Location = new Point(200, 260);
                filterFromLabel.Font= new Font("Century Gothic", 32);
                filterFrom.Size = new Size(520, 22);
                filterFrom.Location = new Point(200, 320);
                filterFrom.Font= new Font("Century Gothic", 22);
                filterToLabel.Size = new Size(77, 19);
                filterToLabel.Location = new Point(200, 370);
                filterToLabel.Font= new Font("Century Gothic", 32);
                filterTo.Size = new Size(520, 22);
                filterTo.Location = new Point(200, 430);
                filterTo.Font=new Font("Century Gothic", 22);
                findPictureBox.Size = new Size(576, 429);
                findPictureBox.Location = new Point(170, 550);
            }
        }

    }

}







