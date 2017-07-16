using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public TextMesh gameOverText;

	
	void FixedUpdate () {
	if (Death.gameOver == true) {
						gameOverText.text = "Game Over";		
				} else {
						gameOverText.text = "ScoreBoard";
				}
		}
}
