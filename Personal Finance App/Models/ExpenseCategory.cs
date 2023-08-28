namespace Personal_Finance_Manager.Models
{
   public class ExpenseCategory
{
        public int ExpenseCategoryID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Expense> Expenses { get; set; }
    }

}
