using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ludilo {
  [System.Serializable]
  public class GameObjectReference : GenericReference<GameObjectVariable, GameObject> {

    public GameObjectReference(GameObjectVariable variable = null) : base(variable) {}
  }
}
