using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Kulka : MonoBehaviour {
	float maxSpeed=10;//Replace with your max speed
	float minSpeed=7;//Replace with your min speed
	float difficulty;
	Vector2 wektor = new Vector2(3f,5f);
	public Object splash;
	public AudioClip[] audioClip;
	public AudioSource input;
	// Use this for initialization
	void Awake () {
				GetComponent<Rigidbody2D>().AddForce (wektor, ForceMode2D.Impulse);
	}

	void Start (){
		if(PlayerPrefs.GetInt("Toggle Difficulty")==2){
			difficulty=1.5f;
		}
		else if(PlayerPrefs.GetInt("Toggle Difficulty")==1){
			difficulty=1.3f;
		}
		else{
			difficulty=1;
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(PlayerPrefs.GetInt("Toggle Sound")==1){
		if(collision.transform.tag=="Death"){
			if(input.isPlaying){
				input.Stop();
				input.clip = audioClip[1];
				input.Play();
			}else{
			input.clip = audioClip[1];
				input.Play();
			}
		}
		else{
				if(input.isPlaying){
			input.Stop();
			input.clip = audioClip[0];
					input.Play();
				}
				else
				{
					input.clip = audioClip[0];
					input.Play();
				}
		}
		}
	}



	void Update()
	{
		if(GetComponent<Rigidbody2D>().velocity.magnitude > maxSpeed)
		{
			GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * maxSpeed * difficulty;
		}
		if(GetComponent<Rigidbody2D>().velocity.magnitude < minSpeed)
		{
			GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * minSpeed * difficulty;
		}
		if (Death.gameOver == true) {
			GetComponent<Renderer>().enabled = false;
			GetComponent<Collider2D>().enabled=false;
				} else {
			GetComponent<Renderer>().enabled = true;
			GetComponent<Collider2D>().enabled=true;
		}
	}

}
