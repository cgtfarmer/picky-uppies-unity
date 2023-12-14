using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Player")]
public class Player: ScriptableObject {

  [ColorUsage(true)]
  [Tooltip("The color")]
  public Color color;

  [Range(0, 1)]
  [Tooltip("Interact radius")]
  public float interactRadius;

  [Range(0, 25)]
  [Tooltip("Movement speed")]
  public float moveSpeed;
}
