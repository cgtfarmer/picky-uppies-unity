using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour {

  private void OnEnable() {
    PlayerController.onInteract += HandlePlayerInteractEvent;
  }

  private void OnDisable() {
    PlayerController.onInteract -= HandlePlayerInteractEvent;
  }

  public void Die() {
    gameObject.SetActive(false);
  }

  public void HandlePlayerInteractEvent(string name) {
    if (name != gameObject.name) return;

    print($"Picked up {gameObject.name}!");
    this.Die();
  }
}
