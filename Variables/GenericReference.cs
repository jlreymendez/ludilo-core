using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {

  abstract public class BaseReference {}

  abstract public class GenericReference<T, K> : BaseReference where T : GenericVariable<K> {
    [SerializeField] protected bool _useConstant = true;
    [SerializeField] protected K _constantValue;
    [SerializeField] protected T _variable;

    public GenericReference(T variable = null) {
      _useConstant = variable == null;
      _variable = variable;
    }

    public bool Initialized {
      get { return _useConstant || _variable != null; }
    }

    public K Value {
      get {
        return _useConstant ? _constantValue : _variable != null ? _variable.Value : default(K);
      }
      set {
        if (_useConstant) {
          _constantValue = value;
        } else {
          _variable.Value = value;
        }
      }
    }

    public void Reset() {
      if (!_useConstant) {
        _variable.Reset();
      }
    }

    public void AddListener(OnValueChanged listener) {
      if (!_useConstant) {
        _variable.Changed += listener;
      }
    }

    public void RemoveListener(OnValueChanged listener) {
      if (!_useConstant) {
        _variable.Changed -= listener;
      }
    }

    public static implicit operator K(GenericReference<T, K> reference) {
      return reference.Value;
    }

    public static implicit operator string(GenericReference<T, K> reference) {
      return reference.Value.ToString();
    }
  }
}
