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
using System.Windows.Shapes;

namespace W25Week6WpfControls
{
    /// <summary>
    /// Interaction logic for UserInteractionControls.xaml
    /// </summary>
    public partial class UserInteractionControls : Window
    {
        public UserInteractionControls()
        {
            InitializeComponent();
        }

        private void btnGetCities_Click(object sender, RoutedEventArgs e)
        {
            string cities = "";

            if (chkToronto.IsChecked == true)
                cities += chkToronto.Content + "\n";
            if (chkParis.IsChecked == true)
                cities += chkParis.Content + "\n";
            if (chkTokyo.IsChecked == true)
                cities += chkTokyo.Content + "\n";
            if (chkSydney.IsChecked == true)
                cities += chkSydney.Content + "\n";

            lblOutput.Content = cities;
        }

        private void btnGetGender_Click(object sender, RoutedEventArgs e)
        {
            string gender = "";

            if (rdoFemale.IsChecked == true)
                gender = rdoFemale.Content.ToString();
            else if (rdoMale.IsChecked == true)
                gender = rdoMale.Content.ToString();
            else if (rdoOther.IsChecked == true)
                gender = rdoOther.Content.ToString();

            lblOutput.Content = "Gender = " + gender;
        }

        private void btnGetCar_Click(object sender, RoutedEventArgs e)
        {
            if (cmbCar.SelectedItem != null)
                lblOutput.Content = cmbCar.Text;
            else
                lblOutput.Content = "Please select a car";
        }

        private void cmbCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCar.SelectedItem != null)
                //lblOutput.Content = cmbCar.Text;
                lblOutput.Content = ((ComboBoxItem)cmbCar.SelectedItem).Content;
            else
                lblOutput.Content = "Please select a car";
        }
    }
}
