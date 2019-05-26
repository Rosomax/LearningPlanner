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
        }


        public int Nazwa { get; set; }
        public int Kategoria { get; set; }
        public int Opis { get; set; }


        private void ZadanieForm_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);

            EntitiesModel2 model = new EntitiesModel2();
            //  ZadaniaDataGridView1.DataSource = model.Zadania.ToList();
            ZadaniaDataGridView1.DataSource = model.Zadania.Select(o => new
            { Nazwa = o.Nazwa, Kategoria = o.Kategoria, Opis = o.Opis }).ToList();


            
        }
    }
}
