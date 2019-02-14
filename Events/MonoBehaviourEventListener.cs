using UnityEngine;
using UnityEngine.Events;

namespace Ludilo {
  public class MonoBehaviourEventListener : GameEventListener<MonoBehaviourEvent, MonoBehaviourUnityEvent, MonoBehaviour> {}

  [System.Serializable]
  public class MonoBehaviourUnityEvent : UnityEvent<MonoBehaviour> {}
}