using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObjects/Counter")]
public class Counter: ScriptableObject {

  [Range(1, 1000)]
  [Tooltip("Max count")]
  public int maxCount;

  public int count;

  // private void OnEnable() {
  //   // this.count = 0;
  // }

  public void Increment() {
    this.count += 1;
  }

  public void IsMax() {
    return this.count >= this.maxCount;
  }
}
