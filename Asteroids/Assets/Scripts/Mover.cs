using UnityEngine;
using System.Collections;

// moves bolt in one direction
public class Mover : MonoBehaviour {

	public float speed;

	void Start() {
		this.GetComponent<Rigidbody2D> ().velocity = transform.up * speed;
	}
}
