using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace White_Ch11._1
{
    //Derive the class from the 
    class ShiftSupervisor : Employee
    {
        
        public ShiftSupervisor()
        {
            AnnualWages = 0;
            ProductionBonus = 0;
            ShiftNumber = 0;
            HourlyWages = 0;


        }
        public float AnnualWages { get; set; }
        public float ProductionBonus { get; set; }

        public float HourlyWages { get; set; }
        public float ShiftNumber { get; set; }

        public override void EmpMessage()
        {
            MessageBox.Show("New Shift Supervisor Employee");
        }
    }
}
