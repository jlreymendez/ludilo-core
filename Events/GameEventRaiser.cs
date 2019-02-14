using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Ludilo {
  public class GameEventRaiser : MonoBehaviour {

    [SerializeField] GameEvent _event;

    void Update() {
      Raise();
      enabled = false;
    }

    public void Raise() {
      if (_event != null) {
        _event.Raise();
      }
    }

    public void Raise(GameEvent gameEvent) {
      if (gameEvent != null) {
        gameEvent.Raise();
      }
    }
  }

  public class GameEventRaiser<T, K> : MonoBehaviour where T : GameEvent<K> {

    [SerializeField] T _event;

    public void Raise(K data) {
      if (_event != null) {
        _event.Raise(data);
      }
    }
  }
}
