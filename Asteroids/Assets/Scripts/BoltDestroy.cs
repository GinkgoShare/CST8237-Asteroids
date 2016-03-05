using UnityEngine;
using System.Collections;

public class BoltDestroy : MonoBehaviour {

	public GameObject explosion;

	// this script attaches to small asteroids to destroy them on collisions
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Bolt")) {
			Destroy (other.gameObject);
			Vector3 position = transform.position;
			Quaternion rotation = transform.rotation;
			Instantiate (explosion, position, rotation);
			Destroy (gameObject);
		}
	}
}
