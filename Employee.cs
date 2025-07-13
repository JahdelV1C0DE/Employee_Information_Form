using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace White_Ch11._1
{
    internal class Employee
    {
        
        public Employee()
        {
            name = "";
            number = 0;
        }
        public string name { get; set; }
        public int number { get; set; }

        public virtual void EmpMessage()
        {
            MessageBox.Show("New Production Employee");
        }
    }

    
}
