namespace Personal_Finance_Manager.Models
{
    public class Income
    {
        public int IncomeID { get; set; }
        public int UserID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }

}
