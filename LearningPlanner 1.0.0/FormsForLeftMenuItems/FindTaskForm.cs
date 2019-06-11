using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.Cursor = new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);

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

        private void FindTaskForm_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width <= 799)
            {
                FindTaskDataGrid.Size = new Size(488, 500);

            }
            else if (Size.Width >= 800)
            {

                FindTaskDataGrid.Size = new Size(700, 404);
            }
        }
    }

}

  


    


