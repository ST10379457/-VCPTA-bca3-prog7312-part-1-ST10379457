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

namespace ST10379457_PROG7312_POE
{
    /// <summary>
    /// Interaction logic for BadgesEarned.xaml
    /// </summary>
    public partial class BadgesEarnedPage : Window
    {
        public BadgesEarnedPage()
        {
            InitializeComponent();

            int reportCount = ReportList.GetReportCount();

            if (reportCount >= 1)
            {
                imgFirstBadge.Visibility = Visibility.Visible;
            }
                

            if (reportCount >= 10)
            {
                imgTenBadge.Visibility = Visibility.Visible;
            }
                

            if (reportCount >= 50)
            {
                imgFiftyBadge.Visibility = Visibility.Visible;
            }
                

            if (reportCount >= 100)
            {
                imgHundredBadge.Visibility = Visibility.Visible;
            }
                
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
