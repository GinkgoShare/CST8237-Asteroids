using UnityEngine;
using System.Collections;

public class MoveAsteroid : MonoBehaviour {

	public float minForce;
	public float maxForce;

	// apply random force to the asteroid
	void Start () {
		float x = Random.Range (-1f, 1f);
		float y = Random.Range (-1f, 1f);
		float magnitude = Random.Range (minForce, maxForce);
		gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2(x, y) * magnitude);
	}
}
