using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Ludilo {
  [CustomEditor(typeof(GameEvent))]
  public class GameEventEditor : Editor {

    public override void OnInspectorGUI() {
      var gameEvent = target as GameEvent;

      if (GUILayout.Button("Raise")) {
        gameEvent.Raise();
      }
    }
  }
}
