using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSpawner : MonoBehaviour {

  public GameObject objectToSpawn;

  public Transform parentTransform;

  public int spawnCount;

  new private Camera camera;

  private Bounds cameraBounds;

  // public Vector3 minPosition;
  // public Vector3 maxPosition;

  void Start() {
    // this.camera = this.GetComponent<Camera>();
    this.camera = Camera.main;

    this.cameraBounds = new Bounds(
      new Vector3(0, 0, 0),
      new Vector3(
        this.camera.orthographicSize * 2 * this.camera.aspect,
        this.camera.orthographicSize * 2,
        0
      )
    );

    this.SpawnGameObjects();
  }

  private void SpawnGameObjects() {
    for (int i = 0; i < this.spawnCount; i++) {
      GameObject go = Instantiate(
        this.objectToSpawn,
        this.GetRandomPosition(),
        Quaternion.identity,
        this.parentTransform
      );

      go.name = $"Resource {i}";
      GameObject sprite = go.transform.Find("GFX").gameObject;
      sprite.GetComponent<SpriteRenderer>().color = new Color(50, 50, 50);
    }
  }

  private Vector3 GetRandomPosition() {
    return new Vector3(
      Random.Range(cameraBounds.min.x, cameraBounds.max.x),
      Random.Range(cameraBounds.min.y, cameraBounds.max.y),
      Random.Range(cameraBounds.min.z, cameraBounds.max.z)
    );
  }
}
