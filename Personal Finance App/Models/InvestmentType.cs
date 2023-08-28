namespace Personal_Finance_Manager.Models
{
    public class InvestmentType
    {
        public int InvestmentTypeID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Investment> Investments { get; set; }
    }

}
