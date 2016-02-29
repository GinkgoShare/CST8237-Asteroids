using UnityEngine;
using System.Collections;

public class InstantiateAsteroids : MonoBehaviour {

	public float minX;
	public float maxX;
	public float minY;
	public float maxY;
	public GameObject asteroid;

	void Start () {
		for (int i = 0; i < 5; ++i) {
			float x = Random.Range (minX, maxX);
			float y = Random.Range (minY, maxY);
			Instantiate (asteroid, new Vector3(x, y, -5f), new Quaternion());
		}
	}
}
