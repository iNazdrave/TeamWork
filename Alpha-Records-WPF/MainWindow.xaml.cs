using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.DataLayer;
using Alpha_Records_WPF.DataLayer.Contracts;
using Alpha_Records_WPF.Factory;

using System;
using System.Collections.Generic;
using System.Windows;

namespace Alpha_Records_WPF
{
    public partial class MainWindow : Window
    {
        private readonly ModelsFactory factory;
        private readonly IDataManager dataManager;

        public MainWindow()
        {
            InitializeComponent();
            factory = ModelsFactory.Instance;
            dataManager = ExcelManager.Instance;
        }

        private void Ranks_Button_Click(object sender, RoutedEventArgs e)
        {
            //this.Objects_List.ItemsSource = 

        }

        private void Presentation_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Library_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Students_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Objects_List.ItemsSource = this.dataManager.GetStudents();
        }

        public static string UpComingPresentationCheck(IEnumerable<IPresentation> studentPresentations, string message)
        {
            TimeSpan days = TimeSpan.Zero;
            foreach (IPresentation presentation in studentPresentations)
            {
                if (DateTime.Today < presentation.Date)
                {
                    days = presentation.Date - DateTime.Now;
                    break;
                }
            }
            return string.Format("You have presentation in {0} days.", days.Days);
        }
    }
}
