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

namespace ATM
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {

        public MainMenu()
        {
            InitializeComponent();
            this.welcome_label.Content = "Welcome " + Globals.loginAccount.name;
        }




        private void button_home_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            NavigationService service =  NavigationService.GetNavigationService(this);
            MessageBoxResult messageBoxResult = 
                System.Windows.MessageBox.Show("Are you sure?", 
                                               "Delete Confirmation", 
                                               System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                service.Navigate(loginPage);
            }

        }

        private void button_view_balance_Click(object sender, RoutedEventArgs e)
        {
            Balance_view balance = new Balance_view();
            NavigationService service =  NavigationService.GetNavigationService(this);
            service.Navigate(balance);

        }

        private void button_withdraw_Click(object sender, RoutedEventArgs e)
        {
            WithdrawPage withDrawPage = new WithdrawPage();
            NavigationService service =  NavigationService.GetNavigationService(this);
            service.Navigate(withDrawPage);

        }

        private void button_history_Click(object sender, RoutedEventArgs e)
        {
            History history = new History();
            NavigationService service =  NavigationService.GetNavigationService(this);
            service.Navigate(history);
        }
    }
}
