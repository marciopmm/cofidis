namespace Cofidis.Domain.Entities
{
    public class UserData
    {
        public string Name { get; set; }
        public string Nif { get; set; }
        public string PhoneNumber { get; set; }
        public decimal MontlyIncome { get; set; }
        public IEnumerable<CreditOperation> CreditHistory { get; set; }
    }
}
