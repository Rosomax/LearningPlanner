using System;
using System.Linq;
using System.Windows.Forms;

namespace LearningPlanner
{
    public partial class QuotationControl : UserControl
    {
        public QuotationControl()
        {
            InitializeComponent();
            Load += QuotationControl_Load;
         
        }

        private void QuotationControl_Load(object sender, EventArgs e)
        {
            
            using (LearningPlannerDataBaseEntities context = new LearningPlannerDataBaseEntities())
            {
                int quotationSum = context.Quotations.Count();

                Random rand = new Random();
                int randomQuotation = rand.Next(quotationSum) + 1;

                var tmp = context.Quotations.Single(p => p.IDCytatu == randomQuotation);
                QuotationLabel.Text = tmp.Tresc;

            }
            
        }

       
    }
}
