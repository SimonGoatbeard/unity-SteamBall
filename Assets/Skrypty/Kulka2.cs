using UnityEngine;
using System.Collections;

public class Kulka2 : MonoBehaviour {
	public float maxSpeed;//Replace with your max speed
	Vector2 wektor = new Vector2(-5,-5);
	public Object splash;
	// Use this for initialization
	void Awake () {

				GetComponent<Rigidbody2D>().AddForce (wektor, ForceMode2D.Impulse);
		 
	}

	void OnCollisionEnter2D(Collision2D collision){
		Object.Instantiate(splash,transform.position,transform.rotation);
	}


	void FixedUpdate()
	{
		if(GetComponent<Rigidbody2D>().velocity.magnitude > maxSpeed)
		{
			GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * maxSpeed;
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
