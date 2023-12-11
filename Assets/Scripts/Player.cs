using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  public float interactRadius;

  void Start() {
  }

  void Update() {
  }

  void OnDrawGizmosSelected() {
    Gizmos.DrawWireSphere(this.transform.position, this.interactRadius);
  }
}
