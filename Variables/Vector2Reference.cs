using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  [System.Serializable]
  public class Vector2Reference : GenericReference<Vector2Variable, Vector2> {

    public Vector2Reference(Vector2Variable variable = null) : base(variable) {}
  }
}
