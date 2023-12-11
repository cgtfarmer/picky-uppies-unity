using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

  public static event System.Action<string> onInteract;

  public LayerMask interactableLayers;

  // new Camera camera;
  private PlayerMotor motor;

  private Player player;

  void Start() {
    // this.camera = Camera.main;
    this.player = this.GetComponent<Player>();
    this.motor = this.GetComponent<PlayerMotor>();
  }

  void Update() {
    this.motor.SetMovement(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    if (Input.GetKeyDown(KeyCode.Space)) {
      this.AttemptInteract();
    }
  }

  private void AttemptInteract() {
    print("[AttemptInteract]");
    Collider2D intersections = Physics2D.OverlapCircle(
      this.transform.position, this.player.interactRadius, this.interactableLayers
    );

    if (intersections == null) return;

    PlayerController.onInteract?.Invoke(intersections.gameObject.name);
  }
}
