namespace Stocks.Domain.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        //public Exchange Exchange { get; set; }
    }
}
