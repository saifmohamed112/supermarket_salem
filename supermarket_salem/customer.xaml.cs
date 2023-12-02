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
    /// Interaction logic for customer.xaml
    /// </summary>
    public partial class customer : Page
    {
        db_supermarketEntities3 db = new db_supermarketEntities3();
        public customer()
        {
            InitializeComponent();
        }

        private void Se_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = int.Parse(ID_Txt.Text);
                DG.ItemsSource = db.Products.Where(x => x.Product_Id == id && x.Product_Name == Name_Txt.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void End_butt_Click(object sender, RoutedEventArgs e)
        {
            end endp = new end();
            this.NavigationService.Navigate(endp);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = db.Products.ToList();
        }
    }
}
