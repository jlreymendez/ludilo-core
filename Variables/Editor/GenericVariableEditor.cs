using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Ludilo {
  [CustomEditor(typeof(BaseVariable), true)]
  public class GenericVariableEditor : Editor {

    bool _runtimeFoldout = true;

    public override void OnInspectorGUI() {
      // Draw super.
      base.OnInspectorGUI();
      // Only show on runtime.
      if (Application.isPlaying) {
        EditorGUILayout.Separator();
        _runtimeFoldout = EditorGUILayout.Foldout(_runtimeFoldout, "Runtime");
        if (_runtimeFoldout) {
          EditorGUI.BeginDisabledGroup(true);
          EditorGUILayout.TextField("Value", ((IStringifiable)target).Stringify());
          EditorGUI.EndDisabledGroup();
        }
      }
    }
  }
}