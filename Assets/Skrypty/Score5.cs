using UnityEngine;
using System.Collections;

public class Score5 : MonoBehaviour {
	public TextMesh scoreText;
	private int score=0;
	public GameObject kuleczka;
	
	void Awake () {
		InvokeRepeating ("UpdateScoreText", 0.5f, 0.5f);
	}
	
	void UpdateScoreText(){
		if (Death.gameOver == false) {
			score += 1;
			if(score==3){
				GameObject.Instantiate(kuleczka);
			}
			if(score==6 && PlayerPrefs.GetInt("Toggle SecondBall")==1){
				GameObject.Instantiate(kuleczka);
			}
			scoreText.text = score.ToString ();
		} else {
			if(score>PlayerPrefs.GetInt("LvL5 Score")){
				PlayerPrefs.SetInt("LvL5 Score", score);
			}
		}
	}
	
}
