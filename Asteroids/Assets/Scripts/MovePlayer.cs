/* 
This system uses some assets taken from the Space Shooter tutorial from Unity
tutorials: http://unity3d.com/learn/tutorials/projects/space-shooter-tutorial.
	- explosions and bolts
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MovePlayer : MonoBehaviour {

	public Text score;
	public Text newGame;
	public float rotationSpeed;
	public float thrustForce;
	public GameObject bolt;
	public Transform boltSpawn;
	public GameObject explosion;
	public GameObject life1;
	public GameObject life2;
	public GameObject life3;
	public float fireRate;
	public int lives;

	private float _nextFire;
	private List<GameObject> _lifeSprites = new List<GameObject> (3);

	// initializes UI objects
	void Start() {
		score.text = "";
		gameObject.SetActive (false);
		life1.SetActive (false);
		_lifeSprites.Add (life1);
		life2.SetActive (false);
		_lifeSprites.Add (life2);
		life3.SetActive (false);
		_lifeSprites.Add (life3);
	}

	void Update() {
		// create a shot when player hits spacebar; utilizes a firerate
		if (Input.GetKey (KeyCode.Space) && Time.time > _nextFire) {
			_nextFire = Time.time + fireRate;
			Instantiate (bolt, boltSpawn.position, boltSpawn.rotation);
		}
	}

	void FixedUpdate() {
		// add force when player wants to move forward
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce (transform.up * thrustForce);
		}
		// rotate spaceship when player uses left/right keys
		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.Rotate (Vector3.back * rotationSpeed, Space.World);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.Rotate (Vector3.forward * rotationSpeed, Space.World);
		}
	}

	// this is trigger for a player crash
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("BigAsteroid") || other.CompareTag ("MedAsteroid") || other.CompareTag ("SmallAsteroid")) {
			Instantiate (explosion, transform.position, transform.rotation); // create explosion visual
			if (lives > 0) {
				_lifeSprites [lives--].SetActive (false); // remove a player life visual
				// reset players position
				transform.position = new Vector3 (0.0f, 0.0f, -5.0f);
				transform.rotation = new Quaternion (0f, 0f, 0f, 0f);
				gameObject.GetComponent<Rigidbody2D> ().velocity = Vector3.zero;
				//Wait ();
			} else {
				newGame.gameObject.SetActive (true);
				_lifeSprites [lives].SetActive (false);
				gameObject.SetActive (false);
			}
		}
	}

	// resets the game
	public void Reset() {
		lives = 2;
		score.text = "0000";
		newGame.gameObject.SetActive (false); // show New Game text
		transform.position = new Vector3 (0.0f, 0.0f, -5.0f);
		transform.rotation = new Quaternion (0f, 0f, 0f, 0f);
		for (int i = 0; i < 3; ++i) _lifeSprites [i].SetActive (true);
		gameObject.SetActive (true);
	}
}
