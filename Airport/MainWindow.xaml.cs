using Airport.ViewModels;
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

namespace Airport
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand RechercherCommand = new RoutedCommand("RechercherVol", typeof(MainWindow));
        public MainWindow()
        {
            InitializeComponent();
        }


        private void RechercherVolCommand(object sender, ExecutedRoutedEventArgs e)
        {
            VMVol context = this.DataContext as VMVol;
            context.Search();
        }

        private void CanExecuteRechercherVol(object sender, CanExecuteRoutedEventArgs e)
        {
            VMVol context = this.DataContext as VMVol;
            if (context != null)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Bye");
        }


    }
}
