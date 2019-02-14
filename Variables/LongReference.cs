using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  [System.Serializable]
  public class LongReference : GenericReference<LongVariable, long> {

    public LongReference(LongVariable variable) : base(variable) {}
  }
}
