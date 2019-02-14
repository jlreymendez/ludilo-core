using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  public class GenericVariable<T> : BaseVariable {

    public event OnValueChanged Changed;

    public T Value {
      get { return GetValue(); }
      set {
        // Set value.
        SetValue(value);
        // Inform change.
        if (Changed != null) {
          Changed();
        }
      }
    }

    [SerializeField] T _defaultValue;
    T _value;

    void OnEnable() {
      Value = _defaultValue;
    }

    public void Reset() {
      Value = _defaultValue;
    }

    protected virtual T GetValue() {
      return _value;
    }

    protected virtual void SetValue(T value) {
      _value = value;
    }

    public override string Stringify() {
      return Value.ToString();
    }

    public static implicit operator T(GenericVariable<T> variable) {
      return variable.Value;
    }

    public static implicit operator string(GenericVariable<T> variable) {
      return variable.Value.ToString();
    }
  }

  public delegate void OnValueChanged();

  public abstract class BaseVariable : ScriptableObject, IStringifiable {
    public abstract string Stringify();
  }
}
