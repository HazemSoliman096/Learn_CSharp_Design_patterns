namespace Builder_Design_Pattern
{
    public class Report
    {
        public string ReportType { get; set; } = string.Empty;
        public string ReportHeader { get; set; } = string.Empty;
        public string ReportFooter { get; set; } = string.Empty;
        public string ReportContent { get; set; } = string.Empty;
        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Content :" + ReportContent);
            Console.WriteLine("Footer :" + ReportFooter);
        }
    }
}
