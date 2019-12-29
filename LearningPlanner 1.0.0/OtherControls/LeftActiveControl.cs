using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LearningPlanner
{

    public partial class LeftActiveControl : UserControl
    {
        // List of controls
       public static List<LeftActiveControl> controlList = new List<LeftActiveControl>();

        public LeftActiveControl()
        {
            InitializeComponent();
            controlList.Add(this);
            
        }
   
        public void SetBackColorMethod(LeftActiveControl control)            
        {           
         control.BackColor= Color.FromArgb(178, 8, 55);               
        }
      

        
    }
}
