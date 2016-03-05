using UnityEngine;
using System.Collections;

// this script attaches to explosion objects to destroy them after a specified time
public class CleanUp : MonoBehaviour {
	void Start () {
		Destroy (gameObject, 2f);
	}
}
