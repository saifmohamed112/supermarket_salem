using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
    /// Interaction logic for signin.xaml
    /// </summary>
    public partial class signin : Page
    {
        db_supermarketEntities3 db = new db_supermarketEntities3 ();
        public signin()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                
                if(Name_Txt.Text !="" || int.Parse(ID_Txt.Text) == null)
                {
                    
                    if (Combo.SelectedItem != null)
                    {
                        int id = int.Parse(ID_Txt.Text);
                        string data = Combo.SelectedItem.ToString().Split(' ').Last();
                        if(data == "Admain")
                        {
                            Admain admain = new Admain();
                            admain = db.Admains.First(x => x.Admain_F_Name == Name_Txt.Text && x.Admain_Id == id);
                            admaindata admaindatap = new admaindata();
                            this.NavigationService.Navigate(admaindatap);
                        }
                        else if(data == "Customer")
                        {
                            Customer customer1 = new Customer();
                            
                            customer1 = db.Customers.First(x => x.Customer_Name == Name_Txt.Text && x.Customer_Id == id);
                            customer customerp = new customer();
                            this.NavigationService.Navigate(customerp);
                        }
                        
                        else if(data == "Employee")
                        {
                            Employee emp = new Employee();
                            emp = db.Employees.First(x => x.Employee_F_Name == Name_Txt.Text && x.Employee_Id == id);
                            addproduct addproductp = new addproduct();
                            this.NavigationService.Navigate(addproductp);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select your job");
                    }
                }
                else
                {
                    MessageBox.Show("Enter data first");
                }
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }
    }
}
