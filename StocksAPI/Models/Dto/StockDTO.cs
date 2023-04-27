namespace StocksAPI.Models.Dto
{
    public class StockDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public decimal LastSalePrice { get; set; }
        public decimal PriceChange { get; set; }
        public decimal PercentChange { get; set; }
        public decimal MarketCap { get; set; }

    }
}
