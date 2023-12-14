using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement: MonoBehaviour {

  public Player player;

  private Rigidbody2D rb;

  private Vector2 movement;

  void Start() {
    this.rb = gameObject.GetComponent<Rigidbody2D>();
  }

  void Update() {
  }

  void FixedUpdate() {
    this.rb.MovePosition(this.rb.position + (
      this.movement.normalized * this.player.moveSpeed * Time.fixedDeltaTime
    ));
  }

  public void SetMovement(float horizontal, float vertical) {
    this.movement = new Vector2(horizontal, vertical);
  }
}
