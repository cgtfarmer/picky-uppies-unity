using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObjects/Events/PickUp")]
public class GameWonEvent: ScriptableObject {

  public UnityEvent e;

  private void OnEnable() {
    if (this.e == null) this.e = new UnityEvent();
  }
}
