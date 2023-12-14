using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObjects/Counter Controller")]
public class CounterController: ScriptableObject {

  // public UnityEvent<int> catchCountChangeEvent;
  public PickUpEvent pickUpEvent;

  public GameWonEvent gameWonEvent;

  public Counter counter;

  // public UnityEvent<bool> gameWonEvent;

  private void OnEnable() {
    // if (this.gameWonEvent == null) this.gameWonEvent = new UnityEvent<int>();
    // if (catchCountChangeEvent == null) catchCountChangeEvent = new UnityEvent<int>();

    this.pickUpEvent.e.AddListener(this.IncrementCounter);
  }

  private void OnDisable() {
    this.pickUpEvent.e.RemoveListener(this.IncrementCounter);
  }

  public void IncrementCounter() {
    this.counter.Increment();

    if (!this.counter.IsMax()) return;

    print("Game won!");
    this.gameWonEvent.e.Invoke();
  }
}

