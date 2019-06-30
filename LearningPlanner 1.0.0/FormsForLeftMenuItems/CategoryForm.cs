﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using LearningPlanner.Properties;

namespace LearningPlanner
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

       private readonly int IDUser = MainForm.UserID;

        EntitiesModel categoryModel = new EntitiesModel();


        private void Category_Load(object sender, EventArgs e)
        {
           // CategoryFormChangeFont();


            BackColor = Color.FromArgb(Settings.Default.RValue, Settings.Default.GValue, Settings.Default.BValue);
            

            chooseCategoryDataGrid.DataSource = categoryModel.Zadania.Select(c => new
            {
                c.Kategoria,
                c.IDUzytkownika

            }).Where(c => c.IDUzytkownika == IDUser).Distinct().ToList();
            chooseCategoryDataGrid.Columns["IDUzytkownika"].Visible = false;

        }

        private void CategoryForm_SizeChanged(object sender, EventArgs e)
        {


            if (Size.Width <= 799)
            {
                DefaultResponsives dresp = new DefaultResponsives();
                dresp.CategoryFormDefaultResponse(this);
            }
            else
            {
                Responsiveness resp = new Responsiveness();
                resp.CategoryResponse(this);
            }

        }


        #region GridHandlers

        private void ChooseCategoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string activeCategoryCell = chooseCategoryDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();


                chooseTaskLabel.Visible = true;
                chooseTaskDataGrid.Visible = true;
                describeTaskLabel.Visible = false;
                describeTaskRichTextBox.Visible = false;
                chooseTaskDataGrid.DataSource = categoryModel.Zadania.Select(t => new
                {
                    t.Nazwa,
                    t.Kategoria,
                    t.IDUzytkownika
                }).Where(t => t.Kategoria == activeCategoryCell).Where(t => t.IDUzytkownika == IDUser).ToList();
            }
            catch
            {

            }


            chooseTaskDataGrid.Columns["Kategoria"].Visible = false;
            chooseTaskDataGrid.Columns["IDUzytkownika"].Visible = false;
        }
    

        private void ChooseTaskDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string activeTaskCell = chooseTaskDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                describeTaskLabel.Visible = true;
                describeTaskRichTextBox.Visible = true;
                describeTaskRichTextBox.Text = GetDescribe(activeTaskCell);
            }
            catch { }
        }

        public string GetDescribe(string activeCell)
        {

            return (from Zadania in categoryModel.Zadania
                    where Zadania.Nazwa.Equals(activeCell)
                    select Zadania.Opis).SingleOrDefault().ToString();
        }

        #endregion


        //#region ChangeFontFromSettings

        //public IEnumerable<Control> GetAll(Control control, Type type)
        //{
        //    var controls = control.Controls.Cast<Control>();

        //    return controls.SelectMany(ctrl => GetAll(ctrl, type))
        //                              .Concat(controls)
        //                              .Where(c => c.GetType() == type);
        //}


        //public void CategoryFormChangeFont()
        //{
        //    string font = Settings.Default.RememberFont;
        //    bool boldFont = Settings.Default.BoldFont;

        //    foreach (var lbl in GetAll(this, typeof(Label)))
        //    {
        //        if (boldFont)
        //            (lbl as Label).Font = new Font(font, 14, FontStyle.Bold);
        //        else
        //            (lbl as Label).Font = new Font(font, 14);

        //    }
          

        //}
        //#endregion


    }
}
