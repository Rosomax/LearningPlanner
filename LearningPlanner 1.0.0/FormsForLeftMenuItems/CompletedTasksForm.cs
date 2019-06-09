using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
namespace LearningPlanner_1._0._0
{
    public partial class CompletedTasksForm : Form
    {
        public CompletedTasksForm()
        {
            InitializeComponent();
        }

        EntitiesModel2 model2 = new EntitiesModel2();

        private int IDUser = MainForm.UserID;

        private void CompletedTasksForm_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);

           
           



            CompletedTaskDataGridView1.DataSource = model2.Zadania.Select(o => new
            {
                o.IDZadania,
                o.Nazwa,
                o.Kategoria,
                o.Opis,
                o.DataUtworzenia,
                o.CzyZakonczone,
                o.IDUzytkownika
            }).Where(o => o.IDUzytkownika == IDUser).Where(o => o.CzyZakonczone == true).ToList();

            // Ukrycie kolumn
            CompletedTaskDataGridView1.Columns["IDZadania"].Visible = false;          
            CompletedTaskDataGridView1.Columns["CzyZakonczone"].Visible = false;
            CompletedTaskDataGridView1.Columns["IDUzytkownika"].Visible = false;

            
        }




    }
}
