using UnityEngine;
using UnityEngine.Events;

namespace Ludilo {
  public class BoolEventListener : GameEventListener<BoolEvent, BoolUnityEvent, bool> {}

  [System.Serializable]
  public class BoolUnityEvent : UnityEvent<bool> {}
}