using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObjects/Events/Interact")]
public class InteractEvent: ScriptableObject {

  public UnityEvent e;

  private void OnEnable() {
    if (this.e == null) this.e = new UnityEvent();

    // if (catchCountChangeEvent == null) catchCountChangeEvent = new UnityEvent<int>();
  }

  // public void IncrementCounter() {
  //   this.counter.Increment();

  //   if (!this.counter.IsMax()) return;

  //   print("Game won!");
  //   this.gameWonEvent.Invoke(true);
  // }
}

