using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  public abstract class BaseGameEvent : ScriptableObject {
    public abstract void RaiseTest();
  }

  [CreateAssetMenu(menuName = "Ludilo/Events/GameEvent")]
  public class GameEvent : ScriptableObject {
    private List<GameEventListener> _listeners = new List<GameEventListener>();

    public void Raise() {
      for (int i = _listeners.Count - 1; i >= 0; i--) {
        _listeners[i].OnEventRaised();
      }
    }

    public void RegisterListener(GameEventListener listener) {
      if (!_listeners.Contains(listener)) {
        _listeners.Add(listener);
      }
    }

    public void UnregisterListener(GameEventListener listener) {
      _listeners.Remove(listener);
    }
  }

  public class GameEvent<T> : BaseGameEvent {
    private List<IRaisableCallback<T>> _listeners = new List<IRaisableCallback<T>>();

    public override void RaiseTest() {
      Raise(default(T));
    }

    public void Raise(T data) {
      for (int i = _listeners.Count - 1; i >= 0; i--) {
        _listeners[i].OnEventRaised(data);
      }
    }

    public void RegisterListener(IRaisableCallback<T> listener) {
      if (!_listeners.Contains(listener)) {
        _listeners.Add(listener);
      }
    }

    public void UnregisterListener(IRaisableCallback<T> listener) {
      _listeners.Remove(listener);
    }
  }
}
