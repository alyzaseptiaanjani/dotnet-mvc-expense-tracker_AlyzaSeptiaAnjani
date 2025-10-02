namespace dotnet_mvc_expense_tracker.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string nama { get; set; }
        public string deskripsi { get; set; }
        public string tipe { get; set; } // e.g., "Income" or "Expense"
        public string status { get; set; } // e.g., "Active" or "Inactive"
    }
}
