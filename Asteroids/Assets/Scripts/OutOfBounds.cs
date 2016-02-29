using UnityEngine;
using System.Collections;

public class Boundary {
	public float minX;
	public float maxX;
	public float minY;
	public float maxY;
}

public class OutOfBounds : MonoBehaviour {

	public float minX;
	public float maxX;
	public float minY;
	public float maxY;

	void Update() {
		float posX, posY;
		if (transform.position.x >= maxX) posX = minX;
		else if (transform.position.x <= minX) posX = maxX;
		else posX = transform.position.x;
		if (transform.position.y >= maxY) posY = minY;
		else if (transform.position.y <= minY) posY = maxY;
		else posY = transform.position.y;
		transform.position = new Vector3 (posX, posY, transform.position.z);
	}
}
