using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Ludilo {
  public class GameEventListener : MonoBehaviour {

    [SerializeField] GameEvent _event;
    [SerializeField] UnityEvent _response;

    void OnEnable() {
      _event.RegisterListener(this);
    }

    void OnDisable() {
      _event.UnregisterListener(this);
    }

    public void OnEventRaised() {
      _response.Invoke();
    }
  }

  public class GameEventListener<T, U, K> : MonoBehaviour, IRaisableCallback<K>
    where T : GameEvent<K>
    where U : UnityEvent<K> {

    [SerializeField] T _event;
    [SerializeField] U _response;

    void OnEnable() {
      _event.RegisterListener(this);
    }

    void OnDisable() {
      _event.UnregisterListener(this);
    }

    public void OnEventRaised(K data) {
      _response.Invoke(data);
    }
  }
}
