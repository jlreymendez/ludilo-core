using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  public class RuntimeSet<T> : ScriptableObject {

    [SerializeField] List<T> _items = new List<T>();

    public IEnumerable Items {
      get { return _items; }
    }

    public void Add(T item) {
      if (!_items.Contains(item)) {
        _items.Add(item);
      }
    }

    public void Remove(T item) {
      if (_items.Contains(item)) {
        _items.Remove(item);
      }
    }

    public bool Contains (T item) {
      return _items.Contains(item);
    }
  }
}