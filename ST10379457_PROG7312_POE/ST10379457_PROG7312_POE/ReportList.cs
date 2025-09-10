using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10379457_PROG7312_POE
{
    //Bro Code (2021):
    public static class ReportList
    {
        private static List<Report> reports = new List<Report>();
        private static int reportsCount = 0;

        public static void AddReport(Report report)
        {
            reports.Add(report);
            reports = reports.ToList();
            reportsCount = reports.Count;
        }

        public static List<Report> GetReports()
        {
            return reports;
        }

        public static int GetReportCount()
        {
            return reportsCount;
        }

        public static string ReportsToString()
        {
            string ToString = "";
            int count = 0;

            foreach (Report report in reports)
            {
                if (count <=0)
                {
                    ToString += "Location: " + report.Location;
                    ToString += "\nCategory: " + report.Category;
                    ToString += "\nDescription: " + report.Description;
                    ToString += "\nMedia File Path: " + report.MediaFilePath;
                    ToString += "\nDate issued: " + report.DateSubmitted.ToString();
                    count++;
                }
                else
                {
                    ToString += "\n\nLocation: " + report.Location;
                    ToString += "\nCategory: " + report.Category;
                    ToString += "\nDescription: " + report.Description;
                    ToString += "\nMedia File Path: " + report.MediaFilePath;
                    ToString += "\nDate issued: " + report.DateSubmitted.ToString();
                    count++;
                }   
            }

            return ToString;
        }
    }
}
/*
 * C# constructors 👷. 2021. YouTube video, added by Bro Code. [Online]. Available at: https://www.youtube.com/watch?v=cAhh6pYkHPQ [Accessed 08 September 2025].
 * C# List of objects 🦸‍. 2021. YouTube video, added by Bro Code. [Online]. Available at: https://www.youtube.com/watch?v=aLhAmimoQj8&list=PLZPZq0r_RZOPNy28FDBys3GVP2LiaIyP_&index=45 [Accessed 08 September 2025].
 * C# static 🚫. 2021. YouTube video, added by Bro Code. [Online]. Available at: https://www.youtube.com/watch?v=8xcIy9cV-6g&list=PLZPZq0r_RZOPNy28FDBys3GVP2LiaIyP_&index=34 [Accessed 08 September 2025].
 */