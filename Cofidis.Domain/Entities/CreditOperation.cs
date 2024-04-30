namespace Cofidis.Domain.Entities
{
    public class CreditOperation
    {
        public DateTime Date { get; set; }
        public decimal PastValue { get; set; }
        public decimal PresentValue { get; set; }
        public decimal OwnedValue { get; set; }
        public bool Settled { get; set; }
    }
}
