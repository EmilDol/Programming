

namespace StockMarket
{
using System.Collections.Generic;
using System;
using System.Text;
    public class Investor
    {

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
        }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        private Dictionary<string, Stock> portfolio = new Dictionary<string, Stock>();

        public Dictionary<string, Stock> Portfolio
        {
            get { return portfolio; }
            set { portfolio = value; }
        }



        public int Count
        {
            get { return Portfolio.Count; }
            private set { Count = value; }
        }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                if (!Portfolio.ContainsKey(stock.CompanyName))
                {
                    Portfolio.Add(stock.CompanyName, stock);
                }
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            if (Portfolio == null)
            {
                return $"{companyName} does not exist.";
            }
            if (!Portfolio.ContainsKey(companyName))
            {
                return $"{companyName} does not exist.";
            }
            if (Portfolio[companyName].PricePerShare > sellPrice)
            {
                return $"Cannot sell {companyName}.";
            }
            else
            {
                Portfolio.Remove(companyName);
                MoneyToInvest += sellPrice;
                return $"{companyName} was sold.";
            }
        }
        public Stock FindStock(string companyName)
        {
            if (Portfolio.ContainsKey(companyName))
            {
                return Portfolio[companyName];
            }
            else
            {
                return null;
            }
        }
        public Stock FindBiggestCompany()
        {
            if (Portfolio == null)
            {
                return null;
            }
            if (Portfolio.Count == 0)
            {
                return null;
            }
            else
            {
                decimal max = decimal.MinValue;
                Stock maxStock = new Stock();
                foreach (var item in Portfolio)
                {
                    if (item.Value.MarketCapitalization > max)
                    {
                        max = item.Value.MarketCapitalization;
                        maxStock = item.Value;
                    }
                }
                return maxStock;

            }
        }

        public string InvestorInformation()
        {
            string output = "";
            output += ($"The investor {FullName} with a broker {BrokerName} has stocks:");
            if (Portfolio != null)
            {
                foreach (var item in Portfolio)
                {
                    output += $"\n{item.ToString()}";
                    string toReplace = $"[{item.Key}, ";
                    output = output.Replace(toReplace,"");
                    output = output.Remove(output.Length - 1, 1);
                }
            }

            return output;
        }
    }
}
