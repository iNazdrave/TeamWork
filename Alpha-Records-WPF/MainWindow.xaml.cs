using Alpha_Records_WPF.DataLayer.Contracts;
using Alpha_Records_WPF.Factory;

using System.Collections.Generic;
using System.Windows;

namespace Alpha_Records_WPF
{
    public partial class MainWindow : Window
    {
        private readonly ModelsFactory factory;
        private readonly  IEnumerable<IDataManager> dataManagers;

        public MainWindow()
        {
            InitializeComponent();
            factory = ModelsFactory.Instance;

        }

        private void Ranks_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Objects_List.ItemsSource = 
        }

        private void Presentation_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Library_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Students_Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
