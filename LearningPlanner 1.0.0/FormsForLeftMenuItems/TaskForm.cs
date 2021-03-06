﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using LearningPlanner.Properties;
using System.Collections.Generic;

namespace LearningPlanner
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {           
            InitializeComponent();            
         
        }

        private readonly int IDUser = MainForm.UserID;

        private void TaskForm_Load(object sender, EventArgs e)
        {
        
            BackColor = Color.FromArgb(Settings.Default.RValue, Settings.Default.GValue, Settings.Default.BValue);

            FillGrid();
            
            TaskDataGridView.Columns["IDZadania"].Visible = false;
            TaskDataGridView.Columns["DataUtworzenia"].Visible = false;
            TaskDataGridView.Columns["CzyZakonczone"].Visible = false;
            TaskDataGridView.Columns["IDUzytkownika"].Visible = false;

           // SaveTaskLogToFile();
            
        }

        private void TaskForm_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width < 799)
            {
                DefaultResponsives dresp = new DefaultResponsives();
                dresp.TaskFormDefaultResponse(this);
            }
            else
            {
                Responsiveness resp = new Responsiveness();
                resp.TaskFormRespons(this);
            }
        }


        #region CRUDMethods
        
        LearningPlannerDataBaseEntities model = new LearningPlannerDataBaseEntities();
      
        public void FillGrid()
        {
            TaskDataGridView.DataSource = model.Tasks.Select(o => new
            {
                o.IDZadania,
                o.Nazwa,
                o.Kategoria,
                o.Opis,
                o.DataUtworzenia,
                o.CzyZakonczone,
                o.IDUzytkownika
            }).Where(o => o.IDUzytkownika == IDUser).Where(o => o.CzyZakonczone == false).ToList();
        }

        Tasks taskModel = new Tasks();

        private void TaskDataGridView_Click(object sender, EventArgs e)
        {
            try
            {              
               if (TaskDataGridView.CurrentRow.Index !=-1 )
                {                                     
                        taskModel.IDZadania = Convert.ToInt32(TaskDataGridView.CurrentRow.Cells["IDZadania"].Value);
                        using (LearningPlannerDataBaseEntities model = new LearningPlannerDataBaseEntities())
                        {
                            taskModel = model.Tasks.Where(x => x.IDZadania == taskModel.IDZadania).FirstOrDefault();
                            TaskNameTextBox.Text = taskModel.Nazwa;
                            CategoryTextBox.Text = taskModel.Kategoria;
                            DescriptionTextBox.Text = taskModel.Opis;
                        }                      
                }
                SaveButton.Text = "Zaaktualizuj";
            }
            catch (NullReferenceException) { }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            taskModel.Nazwa = TaskNameTextBox.Text.Trim();
            taskModel.Kategoria = CategoryTextBox.Text.Trim();
            taskModel.Opis = DescriptionTextBox.Text.Trim();
            taskModel.DataUtworzenia = DateTime.Now;
            taskModel.CzyZakonczone = false;
            taskModel.IDUzytkownika = (short)IDUser;
            if (TaskNameTextBox.Text == string.Empty || CategoryTextBox.Text == string.Empty
                  || DescriptionTextBox.Text == string.Empty)
            {
                MessageBox.Show("Uzupełnij wszystkiego pola!");
            }
            else
            {
                using (LearningPlannerDataBaseEntities dbmodel = new LearningPlannerDataBaseEntities())
                {
                    if (taskModel.IDZadania == 0)
                    {
                        dbmodel.Tasks.Add(taskModel);
                    }
                    else
                    {
                        dbmodel.Entry(taskModel).State = System.Data.Entity.EntityState.Modified;
                    }

                    dbmodel.SaveChanges();
                }
                FillGrid();
                ClearTextBoxes();
                MessageBox.Show("Pomyślnie dodano zadanie");
            }                   
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć to zadanie?", "USUWANIE REKORDU", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    using (LearningPlannerDataBaseEntities dbmodel = new LearningPlannerDataBaseEntities())
                    {
                        var entry = dbmodel.Entry(taskModel);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                            dbmodel.Tasks.Attach(taskModel);
                        dbmodel.Tasks.Remove(taskModel);
                        dbmodel.SaveChanges();

                        MessageBox.Show("Pomyślnie usunięto zadanie");
                    }

                    FillGrid();
                    ClearTextBoxes();
                }
                catch
                {
                    string errorDelete = "Błąd: Nie zaznaczono żadnego rekordu";
                    errorLabel.Visible = true;
                    errorLabel.Text = errorDelete;
                    Timer exceptionTimer = new Timer
                    {
                        Interval = 7000
                    };
                    exceptionTimer.Tick += ExceptionTimer_Tick;
                    exceptionTimer.Start();
                }
        }

        private void ClearTextBoxes()
        {
            TaskNameTextBox.Text = CategoryTextBox.Text = DescriptionTextBox.Text = "";
            SaveButton.Text = "Zapisz";
            taskModel.IDZadania = 0;
        }


        #endregion

        private void SaveTaskLogToFile()
        {
            var tasksNumber = TaskDataGridView.Rows.Count.ToString();
            var actualDate = DateTime.Now.ToString();

            const string path = "Logs\\Log.txt";

            try
            {
                using (StreamWriter write = new StreamWriter(path, true))
                {
                    write.WriteLine("Liczba zadan: " + tasksNumber
                       + ", " + actualDate);
                }
            }
            catch (IOException exc)
            {
                string logError = exc.Message;
                errorLabel.Visible = true;
                errorLabel.Text = logError;
                Timer excTimer = new Timer
                {
                    Interval = 7000
                };
                excTimer.Tick += ExceptionTimer_Tick;
                excTimer.Start();

            }

        }

        public DataGridViewRow SelectedRow { get; private set; }
        public bool Status { get; private set; }
        public static int Id { get; private set; }

        public void TaskDataGridView_DoubleClick(object sender, EventArgs e)
        {
     
            if (TaskDataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = TaskDataGridView.SelectedCells[0].RowIndex;

                SelectedRow = TaskDataGridView.Rows[selectedRowIndex];
              

                var creationDate = DateTime.Now;
                Id = Convert.ToInt32(SelectedRow.Cells["IDZadania"].Value);
                string name = Convert.ToString(SelectedRow.Cells["Nazwa"].Value);
                string category = Convert.ToString(SelectedRow.Cells["Kategoria"].Value);
                string description = Convert.ToString(SelectedRow.Cells["Opis"].Value);
                creationDate = Convert.ToDateTime(SelectedRow.Cells["DataUtworzenia"].Value);
                Status = Convert.ToBoolean(SelectedRow.Cells["CzyZakonczone"].Value);

                TaskInfoForm frm = new TaskInfoForm();

                frm.SetDoubleClickInfo(name, category, description, creationDate);
                frm.Show();

                if (Status)
                    frm.StatusInfoLabel1.Text = "Zakończono";
                else
                    frm.StatusInfoLabel1.Text = "Nie zakończono";


                frm.LoadOrders(this);
            }           
        }

        private void ExceptionTimer_Tick(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            errorLabel.Text = "";
        }

       

    }
}
