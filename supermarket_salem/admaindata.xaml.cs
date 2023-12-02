using System;
using System.Collections.Generic;
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
    /// Interaction logic for admaindata.xaml
    /// </summary>
    public partial class admaindata : Page
    {
        db_supermarketEntities3 db = new db_supermarketEntities3();
        addfromadmain addfromadmainp = new addfromadmain();
        public admaindata()
        {
            InitializeComponent();
        }

        private void Up_butt_Click(object sender, RoutedEventArgs e)
        {
           
            this.NavigationService.Navigate(addfromadmainp);
        }

        private void De_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                int id = int.Parse(ID_Txt.Text);
                emp=db.Employees.First(x => x.Employee_Id == id && x.Employee_F_Name == Name_Txt.Text);
                db.Employees.Remove(emp);
                db.SaveChanges();
                MessageBox.Show("Deleted Siccessfully");
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void Add_butt_Click(object sender, RoutedEventArgs e)
        {
            
            this.NavigationService.Navigate(addfromadmainp);
        }

        private void Se_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = int.Parse(ID_Txt.Text);
                DG.ItemsSource = db.Employees.Where(x => x.Employee_Id == id && x.Employee_F_Name == Name_Txt.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void Re_butt_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = null;
            ID_Txt.Text = "";
            Name_Txt.Text= "";  
        }

        private void Show_butt_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = db.Employees.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            end endp = new end();
            this.NavigationService.Navigate(endp);
        }
    }
}
