using Microsoft.EntityFrameworkCore;

namespace Personal_Finance_Manager.Models
{
    public class PersonaFinanceAppDbContext : DbContext
    {
        public PersonaFinanceAppDbContext(DbContextOptions<PersonaFinanceAppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<InvestmentType> InvestmentTypes { get; set; }
        public DbSet<Investment> Investments { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("FinanceDbConnection");
        //}
    }
}
