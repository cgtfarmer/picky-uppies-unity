using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController: MonoBehaviour {

  // public static event System.Action<string> onInteract;

  public InteractEvent interactEvent;

  // public Player player;

  public LayerMask interactableLayers;

  // new Camera camera;
  private PlayerMovement playerMovement;

  void Start() {
    // this.camera = Camera.main;
    // this.player = this.GetComponent<Player>();
    this.playerMovement = this.GetComponent<PlayerMovement>();
  }

  void Update() {
    this.playerMovement.SetMovement(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    if (Input.GetKeyDown(KeyCode.Space)) {
      this.Interact();
    }
  }

  private void Interact() {
    print("[AttemptInteract]");

    this.interactEvent.e.Invoke();
  }
}
