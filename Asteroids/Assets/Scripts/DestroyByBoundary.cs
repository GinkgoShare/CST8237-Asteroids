using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {
	void OnTriggerExit(Collider other) {
		if (other.CompareTag("Bolt")) Destroy (other.gameObject);
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag("Bolt")) Destroy (other.gameObject);
	}
}
