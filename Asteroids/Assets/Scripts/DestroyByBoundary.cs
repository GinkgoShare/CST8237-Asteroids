using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {
	void OnTriggerExit(Collider other) {
		if (other.CompareTag("Bolt")) Destroy (other.gameObject);
	}
	// destroys bolts that leave the game area
	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag("Bolt")) Destroy (other.gameObject);
	}
}
