using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	public Text scoreText;

	private static int _score = 0;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("BigAsteroid")) {
			_score += 5;
		} else if (other.CompareTag ("MedAsteroid")) {
			_score += 10;
		} else if (other.CompareTag ("SmallAsteroid")) {
			_score += 25;
		}
		scoreText.text = string.Format ("{0:0000}", _score);
	}
}
