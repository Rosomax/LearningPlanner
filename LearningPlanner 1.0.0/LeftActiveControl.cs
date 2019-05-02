using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
      //delegat przyjmujacy kontrolke
    public delegate void SetColorHandler(LeftActiveControl activeControl );

    public partial class LeftActiveControl : UserControl
    {
        // List of controls
       public static List<LeftActiveControl> controlList = new List<LeftActiveControl>();

        public LeftActiveControl()
        {
            InitializeComponent();
            controlList.Add(this);
        
        }

     
        // metoda przyjmujaca delegata
        public void setBackColorMethod(LeftActiveControl control)            
        {           
         control.BackColor= Color.FromArgb(178, 8, 55);
            Console.WriteLine("akuku");
            
        }
      

        
    }
}
