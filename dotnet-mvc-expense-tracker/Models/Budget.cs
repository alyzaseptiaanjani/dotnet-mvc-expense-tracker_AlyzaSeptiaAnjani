namespace dotnet_mvc_expense_tracker.Models
{
    public class Budget
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string deskripsi { get; set; }
        public int total_budget { get; set; }
        public string status { get; set; } // e.g., "Active" or "Inactive"
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool is_repeated { get; set; } = false;
    }
}
