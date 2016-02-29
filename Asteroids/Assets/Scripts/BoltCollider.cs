using UnityEngine;
using System.Collections;

public class BoltCollider : MonoBehaviour {

	public GameObject explosion;
	public GameObject mediumAsteroid;

	public float minForce;
	public float maxForce;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Bolt")) {
			Vector3 thisPosition = transform.position;
			Quaternion thisRotation = transform.rotation;
			Destroy (this.gameObject);
			Destroy (other.gameObject);
			Instantiate (explosion, thisPosition, thisRotation);
			for (int i = 0; i < 3; ++i) {
				float x = Random.Range (-1f, 1f);
				float y = Random.Range (-1f, 1f);
				float magnitude = Random.Range (minForce, maxForce);
				GameObject asteroid = Instantiate (mediumAsteroid, thisPosition, thisRotation) as GameObject;
				asteroid.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (x, y) * magnitude);
			}
		}
	}
}
