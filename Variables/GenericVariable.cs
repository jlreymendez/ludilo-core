using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  public class GenericVariable<T> : BaseVariable {

    public T Value {
      get { return _value; }
      set { _value = value; }
    }

    [SerializeField] T _defaultValue;
    T _value;

    void OnEnable() {
      _value = _defaultValue;
    }

    public void Reset() {
      _value = _defaultValue;
    }

    public override string Stringify() {
      return _value.ToString();
    }

    public static implicit operator T(GenericVariable<T> variable) {
      return variable.Value;
    }

    public static implicit operator string(GenericVariable<T> variable) {
      return variable.Value.ToString();
    }
  }

  public abstract class BaseVariable : ScriptableObject, IStringifiable {
    public abstract string Stringify();
  }
}
