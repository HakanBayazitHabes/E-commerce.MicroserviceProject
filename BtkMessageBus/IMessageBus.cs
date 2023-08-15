namespace BtkMessageBus
{

    public interface IMessageBus
    {
        Task PublishMessage(BaseMessage message, string topicName);
    }
}