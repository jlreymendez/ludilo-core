using UnityEngine;
using UnityEngine.Events;

namespace Ludilo {
  public class IntegerEventListener : GameEventListener<IntegerEvent, IntegerUnityEvent, int> {}

  [System.Serializable]
  public class IntegerUnityEvent : UnityEvent<int> {}
}