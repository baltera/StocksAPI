namespace Stocks.Domain.Models
{
    public class Exchange
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LongName { get; set; }
        public List<Stock> Stocks { get; set; }
    }
}
