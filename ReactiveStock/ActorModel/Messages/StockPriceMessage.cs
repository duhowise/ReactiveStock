using System;

namespace ReactiveStock.ActorModel.Messages
{
    public class StockPriceMessage
    {
        private string _stockSymbol;
        private decimal _stockPrice;
        private DateTime date;

        public StockPriceMessage(string stockSymbol, decimal stockPrice, DateTime date)
        {
            _stockSymbol = stockSymbol;
            _stockPrice = stockPrice;
            this.date = date;
        }
    }
}