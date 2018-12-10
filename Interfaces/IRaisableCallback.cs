namespace Ludilo {
  public interface IRaisableCallback<T> {
    void OnEventRaised(T data);
  }
}