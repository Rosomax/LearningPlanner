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
    public partial class ZadaniaInfoForm : Form
    {
        public ZadaniaInfoForm()
        {
            InitializeComponent();         
        }
       

      
       public void Metoda(string nazw, string kat, string opis, DateTime dataUtw ,string status)
        {
            
            nazwaInfoLbl1.Text = nazw;
            kategoriaInfoLbl1.Text = kat;
            OpisInfoRichTextBox.Text = opis;
            utworzonoInfoLbl1.Text = dataUtw.ToString();
            statusInfoLbl1.Text = status;

        }

        private void ZadaniaInfoForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(138, 197, 222);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            middlePanelInfo.BackColor = Color.FromArgb(178, 8, 55);
            

        }
    }
}
