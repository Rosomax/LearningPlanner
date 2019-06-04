﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace LearningPlanner_1._0._0
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
            TaskDataGridView1.BackgroundColor = Color.FromArgb(178, 8, 55);
            TaskDataGridView1.ForeColor = Color.FromArgb(178, 8, 55);
            Clear();
            
        }

     
        EntitiesModel2 model = new EntitiesModel2();

        private void TaskForm_Load(object sender, EventArgs e)
        {
            
            this.BackColor = Color.FromArgb(138, 197, 222);
        
           
            TaskDataGridView1.DataSource = model.Zadania.Select(o => new
            { o.IDZadania, o.Nazwa,  o.Kategoria,  o.Opis,
                o.DataUtworzenia, o.CzyZakonczone }).ToList();

            // Ukrycie kolumn
            TaskDataGridView1.Columns["IDZadania"].Visible = false;
            TaskDataGridView1.Columns["DataUtworzenia"].Visible = false;
            TaskDataGridView1.Columns["CzyZakonczone"].Visible = false;

            Save();

        }


        Zadania modelz = new Zadania();
        private void TaskDataGridView1_Click(object sender, EventArgs e)
        {
          var  a =  TaskDataGridView1.CurrentRow.Index.ToString();


            if (TaskDataGridView1.CurrentRow.Index != -1)
            {
               modelz.IDZadania = Convert.ToInt32(TaskDataGridView1.CurrentRow.Cells["IDZadania"].Value);
                using (EntitiesModel2 db = new EntitiesModel2())
                {
                    modelz = db.Zadania.Where(x => x.IDZadania == modelz.IDZadania).FirstOrDefault();
                    TaskNameTextBox.Text = modelz.Nazwa;
                    CategoryTextBox.Text = modelz.Kategoria;
                    DescriptionTextBox.Text = modelz.Opis;
                }
                SaveButton.Text = "Zaaktualizuj";
                              
            }
        }
       
        
        // Clearing texts
       private void Clear ()
        {
            TaskNameTextBox.Text = CategoryTextBox.Text = DescriptionTextBox.Text = "";
            SaveButton.Text = "Zapisz";          
            modelz.IDZadania = 0;
        }
        // CRUD's methods
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            modelz.Nazwa = TaskNameTextBox.Text.Trim();
            modelz.Kategoria = CategoryTextBox.Text.Trim();
            modelz.Opis = DescriptionTextBox.Text.Trim();
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

        // Change size
        private void TaskForm_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width <= 799)
            {
                TaskNameTextBox.Size = new Size(220,35);
                CategoryTextBox.Size = new Size(220, 35);
                DescriptionTextBox.Size = new Size(220, 85);
                TaskDataGridView1.Size = new Size(344,500);
                SaveButton.Size = new Size(108, 50);
                SaveButton.Location = new Point(11, 392);
                DeleteButton.Size = new Size(108, 50);
                DeleteButton.Location = new Point(125, 392);
                CancelButton.Size = new Size(108, 50);
                CancelButton.Location = new Point(239, 392);

            }
            else if (Size.Width >= 800)
            {
                TaskNameTextBox.Size = new Size(500, 35);
                CategoryTextBox.Size = new Size(500, 35);
                DescriptionTextBox.Size = new Size(500, 350);
                DescriptionTextBox.Multiline = true;
                SaveButton.Size = new Size(500, 80);
                SaveButton.Location = new Point(65, 660);
                DeleteButton.Size = new Size(500, 80);
                DeleteButton.Location = new Point(65, 750);
                CancelButton.Size = new Size(500, 80);
                CancelButton.Location = new Point(65, 840);
                TaskDataGridView1.Size = new Size(900, 500);
                
            }
        }

        void RefreshGrid ()
        {
            TaskDataGridView1.DataSource = model.Zadania.Select(o => new
            { o.IDZadania, o.Nazwa,  o.Kategoria,  o.Opis,
                o.DataUtworzenia, o.CzyZakonczone }).ToList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy jesteś pewien, że chcesz usunąć to zadanie?", "USUWANIE REKORDU", MessageBoxButtons.YesNo)==DialogResult.Yes)

                try {
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
                catch
                {
                      MessageBox.Show("Nie zaznaczono zadania");
                }
                
                
        }

             

        private void TaskDataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            if (TaskDataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = TaskDataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = TaskDataGridView1.Rows[selectedrowindex];

                string name = Convert.ToString(selectedRow.Cells["Nazwa"].Value);
                string category = Convert.ToString(selectedRow.Cells["Kategoria"].Value);
                string description = Convert.ToString(selectedRow.Cells["Opis"].Value);
                DateTime creationDate = Convert.ToDateTime(selectedRow.Cells["DataUtworzenia"].Value);
                string status = Convert.ToString(selectedRow.Cells["CzyZakonczone"].Value);


                ZadaniaInfoForm frm = new ZadaniaInfoForm();
                frm.Metoda(name, category, description, creationDate, status);
                frm.Show();
              

            }

        }

        

        private void Save()
        {
            if (File.Exists("Log.txt"))
                using (StreamWriter write = new StreamWriter("Logi\\Log.txt", true))
                {
                     write.WriteLine("Liczba zadan: " +
                        TaskDataGridView1.Rows.Count + ", " + DateTime.Now);
                }
               else
                using (StreamWriter write = new StreamWriter("Logi\\Log.txt", false))
                {
                    write.WriteLine("Liczba zadan: " +
                        TaskDataGridView1.Rows.Count + ", " + DateTime.Now);
                    
                }        
            
        }
       



    }
}
