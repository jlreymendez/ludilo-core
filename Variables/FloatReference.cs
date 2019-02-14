using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  [System.Serializable]
  public class FloatReference : GenericReference<FloatVariable, float> {

    public FloatReference(FloatVariable variable = null) : base(variable) {}
  }
}
