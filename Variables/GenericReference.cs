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

    public K Value {
      get {
        return _useConstant ? _constantValue : _variable != null ? _variable.Value : default(K);
      }
    }

    public void Reset() {
      if (!_useConstant) {
        _variable.Reset();
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
