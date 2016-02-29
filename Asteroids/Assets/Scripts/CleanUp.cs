using UnityEngine;
using System.Collections;

public class CleanUp : MonoBehaviour {
	void Start () {
		Destroy (gameObject, 2f);
	}
}
