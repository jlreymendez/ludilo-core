using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  [System.Serializable]
  public class SpriteReference : GenericReference<SpriteVariable, Sprite> {

    public SpriteReference(SpriteVariable variable = null) : base(variable) {}
  }
}
