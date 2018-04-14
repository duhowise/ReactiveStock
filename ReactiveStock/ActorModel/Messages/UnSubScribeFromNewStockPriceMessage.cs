using Akka.Actor;

namespace ReactiveStock.ActorModel.Messages
{
    public class UnSubScribeFromNewStockPriceMessage
    {
        public IActorRef Subscriber { get; private set; }

        public UnSubScribeFromNewStockPriceMessage(IActorRef unsubcribingActor)
        {
            Subscriber = unsubcribingActor;
        }
    }
}