using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace LearningPlanner_1._0._0
{
    public partial class ZadanieForm : Form
    {
        public ZadanieForm()
        {
            InitializeComponent();
            ZadaniaDataGridView1.BackgroundColor = Color.FromArgb(178, 8, 55);
            ZadaniaDataGridView1.ForeColor = Color.FromArgb(178, 8, 55);
            Clear();
            
        }

     
        EntitiesModel2 model = new EntitiesModel2();

        private void ZadanieForm_Load(object sender, EventArgs e)
        {
            

            this.BackColor = Color.FromArgb(138, 197, 222);

          
            //  ZadaniaDataGridView1.DataSource = model.Zadania.ToList();
            ZadaniaDataGridView1.DataSource = model.Zadania.Select(o => new
            { o.IDZadania, o.Nazwa,  o.Kategoria,  o.Opis,
                o.DataUtworzenia, o.CzyZakonczone }).ToList();

            // Ukrycie kolumn
            ZadaniaDataGridView1.Columns["IDZadania"].Visible = false;
            ZadaniaDataGridView1.Columns["DataUtworzenia"].Visible = false;
            ZadaniaDataGridView1.Columns["CzyZakonczone"].Visible = false;

            Zapisz();

        }


        Zadania modelz = new Zadania();
        private void ZadaniaDataGridView1_Click(object sender, EventArgs e)
        {
          var  a =  ZadaniaDataGridView1.CurrentRow.Index.ToString();


            if (ZadaniaDataGridView1.CurrentRow.Index != -1)
            {
               modelz.IDZadania = Convert.ToInt32(ZadaniaDataGridView1.CurrentRow.Cells["IDZadania"].Value);
                using (EntitiesModel2 db = new EntitiesModel2())
                {
                    modelz = db.Zadania.Where(x => x.IDZadania == modelz.IDZadania).FirstOrDefault();
                    NazwaZadaniaTextBox.Text = modelz.Nazwa;
                    KategoriaTextBox.Text = modelz.Kategoria;
                    OpisTextBox.Text = modelz.Opis;
                }
                ZapiszButton.Text = "Zaaktualizuj";
                //   UsunButton.Enabled = true;

                
            }
        }
       
        
        // czyszczenie pol tekstowych
        void Clear ()
        {
            NazwaZadaniaTextBox.Text = KategoriaTextBox.Text = OpisTextBox.Text = "";
            ZapiszButton.Text = "Zapisz";
           // UsunButton.Enabled = false;
            modelz.IDZadania = 0;
        }
        // Metody do CRUD - buttony
        private void AnulujButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            
            modelz.Nazwa = NazwaZadaniaTextBox.Text.Trim();
            modelz.Kategoria = KategoriaTextBox.Text.Trim();
            modelz.Opis = OpisTextBox.Text.Trim();
            modelz.DataUtworzenia = DateTime.Now;
            modelz.CzyZakonczone = false;
            modelz.IDUzytkownika = 1;

            using (EntitiesModel2 db = new EntitiesModel2())
            {
                if (modelz.IDZadania == 0) // Insert
                    db.Zadania.Add(modelz);
                else //update
                {
                    db.Entry(modelz).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges(); 
            }
            RefreshGrid();
            Clear();
            MessageBox.Show("Pomyślnie dodano zadanie");



        }

        // ZMiana ROzmiaru
        private void ZadanieForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width <= 799)
            {
                NazwaZadaniaTextBox.Size = new Size(220,35);
                KategoriaTextBox.Size = new Size(220, 35);
                OpisTextBox.Size = new Size(220, 85);
                ZadaniaDataGridView1.Size = new Size(344,500);
                ZapiszButton.Size = new Size(108, 50);
                ZapiszButton.Location = new Point(11, 392);
                UsunButton.Size = new Size(108, 50);
                UsunButton.Location = new Point(125, 392);
                AnulujButton.Size = new Size(108, 50);
                AnulujButton.Location = new Point(239, 392);

            }
            else if (this.Size.Width >= 800)
            {
                NazwaZadaniaTextBox.Size = new Size(500, 35);
                KategoriaTextBox.Size = new Size(500, 35);
                OpisTextBox.Size = new Size(500, 350);
                OpisTextBox.Multiline = true;
                ZapiszButton.Size = new Size(500, 80);
                ZapiszButton.Location = new Point(65, 660);
                UsunButton.Size = new Size(500, 80);
                UsunButton.Location = new Point(65, 750);
                AnulujButton.Size = new Size(500, 80);
                AnulujButton.Location = new Point(65, 840);
                ZadaniaDataGridView1.Size = new Size(900, 500);
                
            }
        }

        void RefreshGrid ()
        {
            ZadaniaDataGridView1.DataSource = model.Zadania.Select(o => new
            { o.IDZadania, o.Nazwa,  o.Kategoria,  o.Opis,
                o.DataUtworzenia, o.CzyZakonczone }).ToList();
        }

        private void UsunButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy jesteś pewien, że chcesz usunąć to zadanie?", "USUWANIE REKORDU", MessageBoxButtons.YesNo)==DialogResult.Yes)
                using (EntitiesModel2 db = new EntitiesModel2())
                {
                    var entry = db.Entry(modelz);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Zadania.Attach(modelz);
                    db.Zadania.Remove(modelz);
                    db.SaveChanges();
                    RefreshGrid();
                    Clear();
                    MessageBox.Show("Pomyślnie usunięto zadanie");
                }
        }

              

        private void ZadaniaDataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            if (ZadaniaDataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = ZadaniaDataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = ZadaniaDataGridView1.Rows[selectedrowindex];

                string nazwa = Convert.ToString(selectedRow.Cells["Nazwa"].Value);
                string kategoria = Convert.ToString(selectedRow.Cells["Kategoria"].Value);
                string opis = Convert.ToString(selectedRow.Cells["Opis"].Value);
                DateTime dataUtworzenia = Convert.ToDateTime(selectedRow.Cells["DataUtworzenia"].Value);
                string status = Convert.ToString(selectedRow.Cells["CzyZakonczone"].Value);


                ZadaniaInfoForm frm = new ZadaniaInfoForm();
                frm.Metoda(nazwa, kategoria, opis, dataUtworzenia, status);
                frm.Show();
               

            }

        }

        

        public void Zapisz()
        {
            if (File.Exists("Log.txt"))
                using (StreamWriter write = new StreamWriter("Logi\\Log.txt", true))
                {
                     write.WriteLine("Liczba zadan: " +
                        ZadaniaDataGridView1.Rows.Count + ", " + DateTime.Now);
                }
               else
                using (StreamWriter write = new StreamWriter("Logi\\Log.txt", false))
                {
                    write.WriteLine("Liczba zadan: " +
                        ZadaniaDataGridView1.Rows.Count + ", " + DateTime.Now);
                    
                }
          
            
        }
       



    }
}
