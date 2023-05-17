namespace Stocks.Domain.Models
{
    public class StockQuote
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public decimal DayOpen { get; set; }
        public decimal PreviousClosePrice { get; set; }
        public decimal DayPercentChange { get; set; }
        public decimal MarketCap { get; set; }
        public decimal Volume { get; set; }
        public DateTime LastTradeTime { get; set; }
        public int Stock_Id { get; set; }
        public Stock Stock { get; set; }
    }
}
