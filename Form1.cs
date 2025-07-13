using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace White_Ch11._1
{
    
    public partial class EmployeeProductionWorker : Form
    {
        public EmployeeProductionWorker()
        {
            InitializeComponent();
        }
       

        private void CreationofEmployee(ProductionWorker Employee)
        {

            Employee.name = NameBox.Text;
            Employee.number = int.Parse(NumberBox.Text);
            Employee.ShiftNumber = int.Parse(ShiftBox.Text);
            Employee.HourlyWages = float.Parse(WageBox.Text);
            

        }

        private void CreationofSuperVisor(ShiftSupervisor Employee)
        {
            Employee.name = NameBox.Text;
            Employee.number = int.Parse(NumberBox.Text);
            Employee.ShiftNumber = int.Parse(ShiftBox.Text);
            Employee.HourlyWages = float.Parse(WageBox.Text);
            Employee.AnnualWages = float.Parse(AnnualBox.Text);
            Employee.ProductionBonus = float.Parse(BonusBox.Text);


        }

        private void NewEmpBtn_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrWhiteSpace(AnnualBox.Text) || !string.IsNullOrWhiteSpace(BonusBox.Text))
            {
                MessageBox.Show("Employee Can Not Have Production Bonus and/or Annual Wage.");
                
                
            }
            else
            {
                ProductionWorker newWorker = new ProductionWorker();

                CreationofEmployee(newWorker);

                CurrentUserBox.Items.Add(newWorker.name);

                string EmpFile = "Employees.txt";
                NameLbl.Text = newWorker.name;
                //BonusLbl.Text = Supervisor.ProductionBonus.ToString();
                ShiftLbl.Text = newWorker.ShiftNumber.ToString();
                WageLbl.Text = newWorker.HourlyWages.ToString();

                using (StreamWriter writer = new StreamWriter(EmpFile, append: true))
                {
                    writer.WriteLine("PRODUCTION EMPLOYEE");
                    writer.WriteLine("Name of Employee: " + newWorker.name);
                    writer.WriteLine("Employee #: " + newWorker.number);
                    writer.WriteLine("Shift Type: " + newWorker.ShiftNumber);
                    writer.WriteLine("            ");

                }

            }

            


        }

       

        private void NewSuperVisorBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BonusBox.Text) && string.IsNullOrEmpty(AnnualBox.Text))
            {
                MessageBox.Show("Annual Wage and Bonus fields cannot be empty when creating Supervisor ");
             }
            ShiftSupervisor Supervisor = new ShiftSupervisor();
            CreationofSuperVisor(Supervisor);

            string EmpFile = "Employees.txt";
            NameLbl.Text = Supervisor.name;
            //BonusLbl.Text = Supervisor.ProductionBonus.ToString();
            ShiftLbl.Text = Supervisor.ShiftNumber.ToString();
            WageLbl.Text = Supervisor.HourlyWages.ToString();


            using (StreamWriter writer = new StreamWriter(EmpFile, append: true))
            {
                writer.WriteLine("SUPERVISOR");
                writer.WriteLine("Name of Employee: " + Supervisor.name);
                writer.WriteLine("Employee #: " + Supervisor.number);
                writer.WriteLine("Shift Type: " + Supervisor.ShiftNumber);
                writer.WriteLine("Employee Hourly Wage: " + Supervisor.HourlyWages);
                writer.WriteLine("Employee Annual Wages: " + "$" + Supervisor.AnnualWages);
                writer.WriteLine("Employee Bonus: " + "$" + Supervisor.ProductionBonus);
                writer.WriteLine("            ");

            }


        }

        private void EmployeeProductionWorker_Load(object sender, EventArgs e)
        {

        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            string EmpFile = "Employees.txt";

            // Clear the ListBox to avoid duplicating entries


            // Check if the file exists before attempting to read

            // Read all lines from the file
            string[] lines = File.ReadAllLines(EmpFile);

            foreach (var item in lines)
            {
                EmpBox.Items.Add(item);
               
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        //if the 
        private void ShiftBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar != '1' && e.KeyChar != '2' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (ShiftBox.Text.Length > 1 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block the input
            }
        }
    }
}
