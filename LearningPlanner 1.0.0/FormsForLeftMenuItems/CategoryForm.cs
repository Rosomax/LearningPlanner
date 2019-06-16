using System;
using System.Drawing;
using System.Windows.Forms;
using LearningPlanner_1._0._0.Properties;
namespace LearningPlanner_1._0._0
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Settings.Default.track1, Settings.Default.track2, Settings.Default.track3);
        }
    }
}
