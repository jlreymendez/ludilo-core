using UnityEngine;
using UnityEngine.Events;

namespace Ludilo {
  public class FloatEventListener : GameEventListener<FloatEvent, FloatUnityEvent, float> {}

  [System.Serializable]
  public class FloatUnityEvent : UnityEvent<float> {}
}