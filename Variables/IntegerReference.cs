using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  [System.Serializable]
  public class IntegerReference : GenericReference<IntegerVariable, int> {

    public IntegerReference(IntegerVariable variable) : base(variable) {}
  }
}
