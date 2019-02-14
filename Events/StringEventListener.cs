using UnityEngine;
using UnityEngine.Events;

namespace Ludilo {
  public class StringEventListener : GameEventListener<StringEvent, StringUnityEvent, string> {}

  [System.Serializable]
  public class StringUnityEvent : UnityEvent<string> {}
}