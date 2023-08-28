namespace Personal_Finance_Manager.Models
{
    public class User
    {        
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

        public List<Income> Incomes { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<Investment> Investments { get; set; }
    }

}
