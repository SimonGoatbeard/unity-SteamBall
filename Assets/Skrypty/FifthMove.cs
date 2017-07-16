using UnityEngine;
using System.Collections;

public class FifthMove : MonoBehaviour {
	public Vector3 Secbutton;
	public Vector3 Secbuttoniddle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("LvL4 Score") > 50) {
			transform.position = Secbutton;
		} else {
			transform.position = Secbuttoniddle;	
		}
	}
}
