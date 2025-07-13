using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace White_Ch11._1
{
    //create new Production Subclass
    class ProductionWorker : Employee
    {
       
        //Add the Shift Number and Hourly wage so that production workers can be differentiated
        public ProductionWorker()
        {
            ShiftNumber = 0;
            HourlyWages = 0;

        }
        public int ShiftNumber { get; set; }
        public float HourlyWages { get; set; }

        public override void EmpMessage()
        {
            MessageBox.Show("New Production Employee");
        }
    }
}
