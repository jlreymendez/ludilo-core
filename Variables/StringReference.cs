using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  [System.Serializable]
  public class StringReference : GenericReference<StringVariable, string> {

    public StringReference(StringVariable variable = null) : base(variable) {}
  }
}
