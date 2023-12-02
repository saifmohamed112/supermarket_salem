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
    /// Interaction logic for end.xaml
    /// </summary>
    public partial class end : Page
    {
        public end()
        {
            InitializeComponent();
        }

        private void backtowelcome_Click(object sender, RoutedEventArgs e)
        {
            signin signinp = new signin();
            this.NavigationService.Navigate(signinp);
        }

    }
}
