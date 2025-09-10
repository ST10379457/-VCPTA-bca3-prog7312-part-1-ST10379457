using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10379457_PROG7312_POE
{
    //Bro Code (2021):
    public class Report
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaFilePath { get; set; }
        public DateTime DateSubmitted { get; set; }

        public Report(string location, string category, string description, string mediaFilePath)
        {
            Location = location;
            Category = category;
            Description = description;
            MediaFilePath = mediaFilePath;
            DateSubmitted = DateTime.Now;
        }
    }
}
/*
 * C# constructors 👷. 2021. YouTube video, added by Bro Code. [Online]. Available at: https://www.youtube.com/watch?v=cAhh6pYkHPQ [Accessed 08 September 2025].
 */
