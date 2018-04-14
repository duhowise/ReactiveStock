using System;

namespace ReactiveStock.ActorModel.Messages
{
    public class UpdatedStockPriceMessage
    {
        public decimal Price { get;private set; }
        public DateTime Date { get;private set; }

        public UpdatedStockPriceMessage(decimal price,DateTime date)
        {
            Price = price;
            Date = date;
        }
    }
}