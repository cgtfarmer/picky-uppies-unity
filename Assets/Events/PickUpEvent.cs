using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObjects/Events/PickUp")]
public class PickUpEvent: ScriptableObject {

  public UnityEvent<string> e;

  private void OnEnable() {
    if (this.e == null) this.e = new UnityEvent<string>();
  }
}
