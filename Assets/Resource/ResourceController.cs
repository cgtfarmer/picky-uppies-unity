using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObjects/Resource Controller")]
public class ResourceController: ScriptableObject {

  public Counter counter;

  // public UnityEvent<bool> gameWonEvent;

  private void OnEnable() {
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

