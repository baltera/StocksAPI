using Newtonsoft.Json;

namespace Stocks.Infrastructure.Models
{
    public class StockDataResponse
    {
        [JsonProperty("meta")]
        public MetaStockDataResponse Meta { get; set; }
        [JsonProperty("data")]
        public List<QuoteStockDataResponse> Data { get; set; }
    }

    public class MetaStockDataResponse
    {
        [JsonProperty("requested")]
        public int Requested { get; set; }
        [JsonProperty("returned")]
        public int Returned { get; set; }
    }
    public class QuoteStockDataResponse
    {
        [JsonProperty("ticker")]
        public string Ticker { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("exchange_short")]
        public string ExchangeShort { get; set; }
        [JsonProperty("exchange_long")]
        public string ExchangeLong { get; set; }
        [JsonProperty("mic_code")]
        public string MicCode { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("day_high")]
        public decimal DayHigh { get; set; }
        [JsonProperty("day_low")]
        public decimal DayLow { get; set; }
        [JsonProperty("day_open")]
        public decimal DayOpen { get; set; }
        [JsonProperty("52_week_high")]
        public decimal FiftyTwoWeekHigh { get; set; }
        [JsonProperty("52_week_low")]
        public decimal FiftyTwoWeekLow { get; set; }
        [JsonProperty("market_cap")]
        public decimal MarketCap { get; set; }
        [JsonProperty("previous_close_price")]
        public decimal PreviousClosePrice { get; set; }
        [JsonProperty("previous_close_price_time")]
        public DateTime PreviousClosePriceTime { get; set; }
        [JsonProperty("day_change")]
        public decimal DayChange { get; set; }
        [JsonProperty("volume")]
        public decimal Volume { get; set; }
        [JsonProperty("is_extended_hours_price")]
        public bool IsExtendedHoursPrice { get; set; }
        [JsonProperty("last_trade_time")]
        public DateTime LastTradeTime { get; set; }

    }
}
