namespace StockMarket
{
    public class Stock
    {
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
        }
        public Stock()
        {

        }

        //        •	CompanyName: string
        //•	Director: string
        //•	PricePerShare: decimal
        //•	MarketCapitalization: decimal
        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization 
        { 
            get
            {
                return PricePerShare * TotalNumberOfShares;
            }
        }

        public override string ToString()
        {
            return $"Company: {CompanyName}\nDirector: {Director}\nPrice per share: ${PricePerShare}\nMarket capitalization: ${MarketCapitalization}";

        }
    }
}
