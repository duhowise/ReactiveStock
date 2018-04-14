using Akka.Actor;

namespace ReactiveStock.ActorModel.Messages
{
    public class SubScribeToNewStockPricesMessage
    {
        public IActorRef Subscriber { get; private set; }
    }
}