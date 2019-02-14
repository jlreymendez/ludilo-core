using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  [System.Serializable]
  public class Vector3Reference : GenericReference<Vector3Variable, Vector3> {

    public Vector3Reference(Vector3Variable variable = null) : base(variable) {}
  }
}
