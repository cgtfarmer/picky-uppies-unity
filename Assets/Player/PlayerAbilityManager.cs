using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerAbilityManager: MonoBehaviour {

  public InteractEvent interactEvent;

  public PickUpEvent pickUpEvent;

  public Player player;

  public LayerMask interactableLayers;

  public Transform playerTransform;

  private void Interact() {
    print("[AttemptInteract]");

    Collider2D intersection = Physics2D.OverlapCircle(
      this.playerTransform.position, this.player.interactRadius, this.interactableLayers
    );

    if (intersection == null) return;

    this.pickUpEvent.e.Invoke(intersection.gameObject.name)
  }
}

