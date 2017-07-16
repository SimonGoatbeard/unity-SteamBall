using UnityEngine;
using System.Collections;

public class ThirdMove : MonoBehaviour {
	public Vector3 Secbutton;
	public Vector3 Secbuttoniddle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("LvL2 Score") > 50) {
			transform.position = Secbutton;
		} else {
			transform.position = Secbuttoniddle;	
		}
	}
}
