public interface IObserver
{
    void Update(string message);
    void Subscribe(IObservable observer);
    void Unsubscribe(IObservable observer);
}
