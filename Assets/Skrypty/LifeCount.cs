using UnityEngine;
using System.Collections;

public class LifeCount : MonoBehaviour {
	public TextMesh score;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	if (Death.plife == 3) {
			score.text = "∏∏∏";		
		}
	if (Death.plife == 2) {
			score.text = "∏∏";		
		}
	if (Death.plife == 1) {
			score.text = "∏";		
		}
	if (Death.plife == 0) {
			score.text = "";		
		}
	}
}
