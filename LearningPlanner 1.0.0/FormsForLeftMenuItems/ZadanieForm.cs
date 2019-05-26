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
    public partial class ZadanieForm : Form
    {
        public ZadanieForm()
        {
            InitializeComponent();
            ZadaniaDataGridView1.BackgroundColor = Color.FromArgb(178, 8, 55);
            ZadaniaDataGridView1.ForeColor = Color.FromArgb(178, 8, 55);
            
        }


        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public string Opis { get; set; }


        private void ZadanieForm_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);

            EntitiesModel2 model = new EntitiesModel2();
            //  ZadaniaDataGridView1.DataSource = model.Zadania.ToList();
            ZadaniaDataGridView1.DataSource = model.Zadania.Select(o => new
            { Nazwa = o.Nazwa, Kategoria = o.Kategoria, Opis = o.Opis }).ToList();


            
        }

        private void ZadaniaDataGridView1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
