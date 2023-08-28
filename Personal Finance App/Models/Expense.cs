using Personal_Finance_Manager.Models;
namespace Personal_Finance_Manager.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public int UserID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int ExpenseCategoryID { get; set; }
        public User User { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
    }

}
