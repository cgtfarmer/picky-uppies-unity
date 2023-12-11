using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMotor : MonoBehaviour {

  private Rigidbody2D rb;

  private Vector2 movement;

  private float moveSpeed;

  void Start() {
    this.rb = gameObject.GetComponent<Rigidbody2D>();
    this.moveSpeed = 5f;
  }

  void Update() {
  }

  void FixedUpdate() {
    this.rb.MovePosition(this.rb.position + (
      this.movement.normalized * this.moveSpeed * Time.fixedDeltaTime
    ));
  }

  public void SetMovement(float horizontal, float vertical) {
    this.movement = new Vector2(horizontal, vertical);
  }
}
