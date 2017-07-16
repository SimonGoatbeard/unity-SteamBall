using UnityEngine;
using System.Collections;

public class ScoreLvl : MonoBehaviour {
	public TextMesh scoreText1;
	public TextMesh scoreText2;
	public TextMesh scoreText3;
	public TextMesh scoreText4;
	public TextMesh scoreText5;

	// Use this for initialization
	void Start () {
		scoreText1.text=PlayerPrefs.GetInt("LvL1 Score").ToString();
		scoreText2.text=PlayerPrefs.GetInt("LvL2 Score").ToString();
		scoreText3.text=PlayerPrefs.GetInt("LvL3 Score").ToString();
		scoreText4.text=PlayerPrefs.GetInt("LvL4 Score").ToString();
		scoreText5.text=PlayerPrefs.GetInt("LvL5 Score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
