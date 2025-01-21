public class InMemoryServiceBus
{
    private readonly Dictionary<Type, List<Func<object, Task>>> _subscribers = new();

    public void Subscribe<T>(Func<T, Task> handler) where T : class
    {
        var messageType = typeof(T);
        if (!_subscribers.ContainsKey(messageType))
        {
            _subscribers[messageType] = new List<Func<object, Task>>();
        }
        _subscribers[messageType].Add(async (msg) => await handler((T)msg));
    }

    public async Task Publish<T>(T message) where T : class
    {
        var messageType = typeof(T);
        if (_subscribers.ContainsKey(messageType))
        {
            var tasks = _subscribers[messageType].Select(handler => handler(message));
            await Task.WhenAll(tasks);
        }
    }
}