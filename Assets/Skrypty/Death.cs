using UnityEngine;
using System.Collections;
public class Death : MonoBehaviour {
	public Vector3 spawnPoint;
	private int life;
	public static int plife;
	public static bool gameOver;
	// Use this for initialization
	void Start () {
		gameOver = false;
		life = 3;
		plife = 3;
	}



	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.tag == "Ball") {
			if(PlayerPrefs.GetInt("Toggle Invincibility")==0){
			life--;
			plife--;
			}
			if(plife>-1){
				other.transform.position=spawnPoint;
				other.Equals(null);
				}else{
				gameOver=true;
			}

		}
	}
}
