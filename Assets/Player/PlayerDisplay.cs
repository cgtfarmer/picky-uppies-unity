using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisplay: MonoBehaviour {

  public Player player;

  void Start() {
    this.GetComponent<SpriteRenderer>().color = this.player.color;
  }

  void Update() {
  }

  void OnDrawGizmosSelected() {
    Gizmos.DrawWireSphere(this.transform.position, this.player.interactRadius);
  }
}
