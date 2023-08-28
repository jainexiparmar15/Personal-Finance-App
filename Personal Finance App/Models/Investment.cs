namespace Personal_Finance_Manager.Models
{
    public class Investment
    {
        public int InvestmentID { get; set; }
        public int UserID { get; set; }
        public int InvestmentTypeID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public InvestmentType InvestmentType { get; set; }
    }
}
