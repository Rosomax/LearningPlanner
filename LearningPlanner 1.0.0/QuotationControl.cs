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
            
            using (EntitiesModel context = new EntitiesModel())
            {
                int quotationSum = context.Cytaty.Count();

                Random rand = new Random();
                int randomQuotation = rand.Next(quotationSum) + 1;

                var tmp = context.Cytaty.Single(p => p.IDcytatu == randomQuotation);
                QuotationLabel.Text = tmp.Tresc;

            }
            
        }

       
    }
}
