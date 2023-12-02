using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace supermarket_salem
{
    /// <summary>
    /// Interaction logic for addfromadmain.xaml
    /// </summary>
    public partial class addfromadmain : Page
    {
        db_supermarketEntities3 db = new db_supermarketEntities3();
        public addfromadmain()
        {
            InitializeComponent();
        }

        private void Add_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.Employee_Id = int.Parse(ID_Txt.Text);
                emp.Employee_F_Name = Fir_Txt.Text;
                emp.Employee_L_Name = L_N_Txt.Text;
                emp.Employee_Phone = PH_Txt.Text;
                emp.Employee_Position = Pos_TXt.Text;
                emp.Employee_Email = E_Txt.Text;
                emp.Employee_Hiredate = DateTime.Parse(Hir_Txt.Text);
                emp.Department_Id = int.Parse(Dep_Txt.Text);
                emp.Employee_salary = int.Parse(Sal_Txt.Text);
                db.Employees.Add(emp);
                db.SaveChanges();
                MessageBox.Show(" Added successfully ^_^..");
            }
            catch
            {
                MessageBox.Show(" Error Please Try Again..!");

            }
        }

        private void Up_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.Employee_Id = int.Parse(ID_Txt.Text);
                emp.Employee_F_Name = Fir_Txt.Text;
                emp.Employee_L_Name = L_N_Txt.Text;
                emp.Employee_Phone = PH_Txt.Text;
                emp.Employee_Position = Pos_TXt.Text;
                emp.Employee_Email = E_Txt.Text;
                emp.Employee_Hiredate = DateTime.Parse(Hir_Txt.Text);
                emp.Department_Id = int.Parse(Dep_Txt.Text);
                emp.Employee_salary = int.Parse(Sal_Txt.Text);
                db.Employees.AddOrUpdate(emp);
                db.SaveChanges();
                MessageBox.Show(" Updated successfully ^_^..");
            }
            catch
            {
                MessageBox.Show(" Error Please Try Again..!");

            }
        }

        private void Ref_butt_Click(object sender, RoutedEventArgs e)
        {
            ID_Txt.Text = "";
            Fir_Txt.Text = "";
            L_N_Txt.Text = "";
            PH_Txt.Text = "";
            Pos_TXt.Text = "";
            E_Txt.Text = "";
            Hir_Txt.Text = "";
            Dep_Txt.Text = "";
            Sal_Txt.Text = "";
        }
    }
}
