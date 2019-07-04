using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using LearningPlanner.Properties;
using System.Text;
using System.IO;
using System.Collections.Generic;
namespace LearningPlanner
{
    public partial class CompletedTasksForm : Form
    {
        public CompletedTasksForm()
        {
            InitializeComponent();
        }
       
        private readonly int IDUser = MainForm.UserID;

        EntitiesModel model = new EntitiesModel();

        private void CompletedTasksForm_Load(object sender, EventArgs e)
        {

            CompletedTaskFormChangeFont();

            BackColor = Color.FromArgb(Settings.Default.RValue, Settings.Default.GValue, Settings.Default.BValue);



            CompletedTaskDataGridView1.DataSource = model.Zadania.Select(o => new
            {
                o.IDZadania,
                o.Nazwa,
                o.Kategoria,
                o.Opis,
                o.DataUtworzenia,
                o.CzyZakonczone,
                o.IDUzytkownika,

            }).Where(o => o.IDUzytkownika == IDUser).Where(o => o.CzyZakonczone).ToList();

            // Ukrycie kolumn
            CompletedTaskDataGridView1.Columns["IDZadania"].Visible = false;
            CompletedTaskDataGridView1.Columns["CzyZakonczone"].Visible = false;
            CompletedTaskDataGridView1.Columns["IDUzytkownika"].Visible = false;





        }
       


        public void FillGrid()
        {
            CompletedTaskDataGridView1.DataSource = model.Zadania.Select(o => new
            {
                o.IDZadania,
                o.Nazwa,
                o.Kategoria,
                o.Opis,
                o.DataUtworzenia,
                o.CzyZakonczone,
                o.IDUzytkownika,

            }).Where(o => o.IDUzytkownika == IDUser).Where(o => o.CzyZakonczone).ToList();
        }



        public static int Id { get; private set; }
        public DataGridViewRow SelectedRow { get; private set; }

        private void CompletedTaskDataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (CompletedTaskDataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = CompletedTaskDataGridView1.SelectedCells[0].RowIndex;

                SelectedRow = CompletedTaskDataGridView1.Rows[selectedrowindex];


                var creationDate = DateTime.Now;
                Id = Convert.ToInt32(SelectedRow.Cells["IDZadania"].Value);
                string name = Convert.ToString(SelectedRow.Cells["Nazwa"].Value);
                string category = Convert.ToString(SelectedRow.Cells["Kategoria"].Value);
                string description = Convert.ToString(SelectedRow.Cells["Opis"].Value);
                creationDate = Convert.ToDateTime(SelectedRow.Cells["DataUtworzenia"].Value);


                TaskInfoForm frm = new TaskInfoForm();

                frm.SetDoubleClickInfo(name, category, description, creationDate);
                frm.HideFinishTaskButton();

                frm.StatusInfoLabel1.Text = "Zakończono";

                frm.LoadOrders(this);
                frm.Show();


            }


        }


        #region ExportToCSV
        StringBuilder sb = new StringBuilder();

        private void CSVExport()
        {
          
            CompletedTaskDataGridView1.Columns.Remove("IDUzytkownika");
            CompletedTaskDataGridView1.Columns.Remove("IDZadania");
            CompletedTaskDataGridView1.Columns.Remove("CzyZakonczone");


            var headers = CompletedTaskDataGridView1.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));


            foreach (DataGridViewRow row in CompletedTaskDataGridView1.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value).ToArray()));
            }


        }

        private void CSVExportFileDialog()
        {

            saveFileDialog1.FileName = "export.csv";


            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        sw.WriteLine(sb.ToString());
                }
            }
            catch (IOException)
            {
                MessageBox.Show("UPS, cos poszlo nie tak!");
            }

        }


        private void CSVExportButton_Click(object sender, EventArgs e)
        {
            CSVExport();
            CSVExportFileDialog();
        }

        #endregion


        #region ChangeFontFromSettings

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }



        public void CompletedTaskFormChangeFont()
        {
            string font = Settings.Default.RememberFont;
            bool boldFont = Settings.Default.BoldFont;

            foreach (var btn in GetAll(this, typeof(Button)))
            {
                if (boldFont)
                    (btn as Button).Font = new Font(font, 10, FontStyle.Bold);
                else
                    (btn as Button).Font = new Font(font, 10);
            }

            foreach (var grid in GetAll(this, typeof(DataGridView)))
            {
                if (boldFont)
                    (grid as DataGridView).Font = new Font(font, 12, FontStyle.Bold);
                else
                    (grid as DataGridView).Font = new Font(font, 12);
            }

        }

#endregion
    }
}
