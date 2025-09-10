using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
    /// Interaction logic for ReportIssuesPage.xaml
    /// </summary>
    public partial class ReportIssuesPage : Window
    {
        private MainWindow _mainWindow;
        public ReportIssuesPage()
        {
            InitializeComponent();

            //blogize (2023):
            txtLocation.TextChanged += (s, e) => UpdateProgressBar();
            cmbCategory.SelectionChanged += (s, e) => UpdateProgressBar();
            rtbDescription.TextChanged += (s, e) => UpdateProgressBar();
        }
        private void btnAttachFile_Click(object sender, RoutedEventArgs e)
        {
            //Al John Villareal (2023):
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "All Files (*.*)|*.*|Images (*.jpg;*.png)|*.jpg;*.png|Videos (*.mp4;*.avi)|*.mp4;*.avi";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == true)
            {
                txtFilePath.Text = $"Selected: {openFileDialog.FileName}";
                UpdateProgressBar();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    MessageBox.Show("Please indicate the location of the issue.");
                }
                else if (cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a category.");
                }
                else if (string.IsNullOrWhiteSpace(new TextRange(rtbDescription.Document.ContentStart, rtbDescription.Document.ContentEnd).Text))
                {
                    MessageBox.Show("Please provide a detailed description.");
                }
                else if (txtFilePath.Text == "No file selected" || string.IsNullOrWhiteSpace(txtFilePath.Text))
                {
                    MessageBox.Show("Please select a file to upload.");
                }
                else
                {
                    //Bro Code(2021):
                    string location = txtLocation.Text;
                    string category = cmbCategory.Text;
                    string description = new TextRange(rtbDescription.Document.ContentStart, rtbDescription.Document.ContentEnd).Text;
                    string mediaPath = txtFilePath.Text;

                    Report newReport = new Report(location, category, description, mediaPath);

                    ReportList.AddReport(newReport);

                    MessageBox.Show("Report submitted successfully!");

                    //MessageBox.Show(ReportList.ReportsToString());

                    int reportCount = ReportList.GetReportCount();

                    if (reportCount == 1)
                    {
                        MessageBox.Show("Congratulations! You have created your first report!", "New Badge unlocked");
                    }


                    if (reportCount == 10)
                    {
                        MessageBox.Show("Congratulations! You have created your 10th report!", "New Badge unlocked");
                    }


                    if (reportCount == 50)
                    {
                        MessageBox.Show("Congratulations! You have created your 50th report!", "New Badge unlocked");
                    }


                    if (reportCount == 100)
                    {
                        MessageBox.Show("Congratulations! You have created your 100th report!");
                    }

                    txtLocation.Clear();
                    cmbCategory.SelectedIndex = -1;
                    rtbDescription.Document.Blocks.Clear();
                    txtFilePath.Text = "No file selected";

                    UpdateProgressBar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n"+ex);
            }
            
        }

        //blogize (2023):
        private void UpdateProgressBar()
        {   
            int totalFields = 4; // Location, Category, Description, Media
            int completed = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                completed++;

            if (cmbCategory.SelectedIndex != -1)
                completed++;

            string descriptionText = new TextRange(rtbDescription.Document.ContentStart, rtbDescription.Document.ContentEnd).Text;
            if (!string.IsNullOrWhiteSpace(descriptionText.Trim()))
                completed++;

            if (txtFilePath.Text != "No file selected" && !string.IsNullOrWhiteSpace(txtFilePath.Text))
                completed++;

            // Calculate percentage
            double percentage = (completed / (double)totalFields) * 100;
            if (percentage < 25)
            {
                lblProgress.Content = percentage + "% complete: You can do this!";
            }
            else if (percentage < 50)
            {
                lblProgress.Content = percentage + "% complete: Keep going!";
            }
            else if (percentage < 75)
            {
                lblProgress.Content = percentage + "% complete: Half way there!";
            }
            else if (percentage < 100)
            {
                lblProgress.Content = percentage + "% complete: Almost there!";
            }
            else if (percentage >= 100)
            {
                lblProgress.Content = percentage + "% complete: You did it!";
            }
            
            pbFormComplete.Value = percentage;
        }
    }
}
/* Reference list:
 * 
 * Open File Dialog - C# Windows Forms Controls. 2023. YouTube video, added by Al John Villareal. [Online]. Available at: https://www.youtube.com/watch?v=8tnZAIOszAY [Accessed 07 September 2025]. 
 * Creating a Cylindrical Progress Bar in WPF. 2024. YouTube video, added by blogize. [Online]. Available at: https://www.youtube.com/watch?v=yE_NFl9KuvE [Accessed 08 September 2025]. 
 * C# List of objects 🦸‍. 2021. YouTube video, added by Bro Code. [Online]. Available at: https://www.youtube.com/watch?v=aLhAmimoQj8&list=PLZPZq0r_RZOPNy28FDBys3GVP2LiaIyP_&index=45 [Accessed 08 September 2025].
 * C# static 🚫. 2021. YouTube video, added by Bro Code. [Online]. Available at: https://www.youtube.com/watch?v=8xcIy9cV-6g&list=PLZPZq0r_RZOPNy28FDBys3GVP2LiaIyP_&index=34 [Accessed 08 September 2025].
*/
