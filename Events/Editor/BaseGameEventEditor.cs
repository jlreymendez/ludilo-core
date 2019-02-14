using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Ludilo {
  [CustomEditor(typeof(BaseGameEvent), true)]
  public class BaseGameEventEditor : Editor {

    public override void OnInspectorGUI() {
      if (GUILayout.Button("Raise")) {
        (target as BaseGameEvent).RaiseTest();
      }
    }
  }
}
