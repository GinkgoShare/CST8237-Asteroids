using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BoltCollider : MonoBehaviour {

	public GameObject explosion;
	public GameObject mediumAsteroid;
//	public GameObject smallAsteroid;
	public Text scoreText;

	public float minForce;
	public float maxForce;

	// this script attaches to objects and checks if a bolt collides with it
	// I found when I attached this script with the commented out code below to the boltobject itself the game lagged
	void OnTriggerEnter2D(Collider2D other) {
//		Vector3 thisPosition = transform.position;
//		Quaternion thisRotation = transform.rotation;
//		if (other.CompareTag ("BigAsteroid")) {
//			Destroy (this.gameObject);
//			Destroy (other.gameObject);
//			Instantiate (explosion, thisPosition, thisRotation);
//			for (int i = 0; i < 3; ++i) {
//				float x = Random.Range (-1f, 1f);
//				float y = Random.Range (-1f, 1f);
//				float magnitude = Random.Range (minForce, maxForce);
//				GameObject asteroid = Instantiate (mediumAsteroid, thisPosition, thisRotation) as GameObject;
//				asteroid.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (x, y) * magnitude);
//			}
//		} else if (other.CompareTag ("MedAsteroid")) {
//			Destroy (this.gameObject);
//			Destroy (other.gameObject);
//			Instantiate (explosion, thisPosition, thisRotation);
//			for (int i = 0; i < 3; ++i) {
//				float x = Random.Range (-1f, 1f);
//				float y = Random.Range (-1f, 1f);
//				float magnitude = Random.Range (minForce, maxForce);
//				GameObject asteroid = Instantiate (smallAsteroid, thisPosition, thisRotation) as GameObject;
//				asteroid.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (x, y) * magnitude);
//			}
//		} else if (other.CompareTag ("SmallAsteroid")) {
//			Destroy (gameObject);
//			Destroy (other.gameObject);
//			Instantiate (explosion, thisPosition, thisRotation);
//		}

		// Check if the collision is from a bolt object
		if (other.CompareTag ("Bolt")) {
			//scoreText.text = string.Format ("{0:0000}", System.Int16.Parse(scoreText.text) + 20);
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
