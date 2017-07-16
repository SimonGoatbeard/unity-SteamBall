using UnityEngine;
using System.Collections;

public class Destrukcja : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		StartCoroutine(Autodestroy());
	}
	IEnumerator Autodestroy() {
		yield return new WaitForSeconds(GetComponent<ParticleSystem>().duration*2);
		Destroy(this.gameObject);
	}
	void FixedUpdate(){
		if (Death.gameOver == true) {
			GetComponent<Renderer>().enabled = false;		
		} else {
			GetComponent<Renderer>().enabled = true;
		}
	}
}
