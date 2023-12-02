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
    /// Interaction logic for addproduct.xaml
    /// </summary>
    public partial class addproduct : Page
    {
        public addproduct()
        {
            InitializeComponent();
        }
       db_supermarketEntities3 db = new db_supermarketEntities3();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Product product = new Product();
            product.Product_Name = nmetxt.Text;
            product.Product_Id = int.Parse(idtxt.Text);
            product.Product_price = int.Parse(pricetxt.Text);
            product.Sellf_Id = int.Parse(shidtxt.Text);
            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("Added Successfully");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {

                Product product = new Product();

                int ID = int.Parse(idtxt.Text);
                product = db.Products.First(x => x.Product_Id == ID);
                product.Product_Name = nmetxt.Text;
                db.Products.AddOrUpdate(product);
                db.SaveChanges();
                product.Product_price = int.Parse(pricetxt.Text);
                product.Sellf_Id = int.Parse(shidtxt.Text);              
                MessageBox.Show("Updated Successfully");
            }
            catch
            {
                MessageBox.Show("this id invalid");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int ID = int.Parse(idtxt.Text);
                db.Products.Remove(db.Products.First(x => x.Product_Id == ID));
                db.SaveChanges();
                MessageBox.Show("Deleted");
            }
            catch
            {
                MessageBox.Show("this id invalid");
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var ss = int.Parse(idtxt.Text);
            data.ItemsSource = db.Products.Where(x => x.Product_Id == ss).ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            idtxt.Text = "";
            pricetxt.Text = "";
            shidtxt.Text = "";
            nmetxt.Text = "";
            data.ItemsSource = db.Products.ToList();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            data.ItemsSource = db.Products.ToList();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            end endp = new end();
            this.NavigationService.Navigate(endp);
        }
    }
}
