using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceDisplay : MonoBehaviour {

  // [SerializeField]
  // private CatchCountManager catchCountManager;

  public Resource resource;

  private SpriteRenderer spriteRenderer;

  void Start() {
    this.spriteRenderer = this.GetComponent<SpriteRenderer>();
    this.spriteRenderer.color = this.resource.color;
  }

  private void OnEnable() {
    PlayerController.onInteract += OnPlayerInteract;
  }

  private void OnDisable() {
    PlayerController.onInteract -= OnPlayerInteract;
  }

  public void Die() {
    this.gameObject.SetActive(false);
  }

  public void OnPlayerInteract(string name) {
    if (name != gameObject.name) return;

    print($"Picked up {gameObject.name}!");
    this.Die();
  }
}
