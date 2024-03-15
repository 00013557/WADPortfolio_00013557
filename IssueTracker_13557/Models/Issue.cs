namespace IssueTracker_13557.Models
{
    public class Issue
    {
        public int IssueID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }  
        public DateTime CreationDate { get; set; }  
        public DateTime UpdateDate { get; set; }
    }
}
