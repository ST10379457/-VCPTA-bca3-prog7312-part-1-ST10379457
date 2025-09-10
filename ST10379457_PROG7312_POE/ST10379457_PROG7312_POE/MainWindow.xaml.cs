using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ST10379457_PROG7312_POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ReportIssuesPage reportIssuesPage = new ReportIssuesPage();
        private AnnouncementsPage announcementsPage = new AnnouncementsPage();
        private RequestStatusPage requestStatusPage = new RequestStatusPage();
        private BadgesEarnedPage badgesEarnedPage = new BadgesEarnedPage();

        public MainWindow()
        {
            InitializeComponent();
            this.Closed += MainWindow_Closed;
        }

        private void btnReportIssues_Click(object sender, RoutedEventArgs e)
        {
            var reportIssuesPage = new ReportIssuesPage();
            reportIssuesPage.Show();
        }

        private void btnAnnouncements_Click(object sender, RoutedEventArgs e)
        {
            var announcementsPage = new AnnouncementsPage();
            announcementsPage.Show();
        }

        private void btnRequestStatus_Click(object sender, RoutedEventArgs e)
        {
            var requestStatusPage = new RequestStatusPage();
            requestStatusPage.Show();
        }

        private void btnBadges_Click(object sender, RoutedEventArgs e)
        {
            var badgesEarnedPage = new BadgesEarnedPage();
            badgesEarnedPage.Show();
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
