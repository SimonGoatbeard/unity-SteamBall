using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Options : MonoBehaviour {
	public TextMesh textSound;
	public TextMesh textBall;
	public TextMesh textInvincible;
	public TextMesh textDifficulty;
	Ray ray = new Ray ();
	RaycastHit hit = new RaycastHit();
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("Toggle Sound")==0){
			textSound.text="OFF";
		}
		else{
			textSound.text="ON";
		}

		if(PlayerPrefs.GetInt("Toggle SecondBall")==1){
			textBall.text="ON";
		}
		else{
			textBall.text="OFF";
		}

		if(PlayerPrefs.GetInt("Toggle Invincibility")==1){
			textInvincible.text="ON";
		}
		else{
			textInvincible.text="OFF";
		}

		if(PlayerPrefs.GetInt("Toggle Difficulty")==2){
			textDifficulty.text="Hard";
		}
		else if(PlayerPrefs.GetInt("Toggle Difficulty")==1){
			textDifficulty.text="Medium";
		}
		else{
			textDifficulty.text="Easy";
		}


		if(Input.GetMouseButton(0))
		{
			ray= Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit))
			{
				if (hit.transform.name=="Reset")
				{
					PlayerPrefs.SetInt ("LvL1 Score",0);
					PlayerPrefs.SetInt ("LvL2 Score",0);
					PlayerPrefs.SetInt ("LvL3 Score",0);
					PlayerPrefs.SetInt ("LvL4 Score",0);
					PlayerPrefs.SetInt ("LvL5 Score",0);
				}
				if (hit.transform.name=="Sound")
				{
					StartCoroutine("waitForSound");
				}
				if (hit.transform.name=="Ball")
				{
					StartCoroutine("waitForBall");
				}
				if (hit.transform.name=="Invincible")
				{
					StartCoroutine("waitForInvincible");
				}
				if (hit.transform.name=="Difficulty")
				{
					StartCoroutine("waitForDifficulty");
				}

			}
			
		}
	}
	IEnumerator waitForSound() {
		if(PlayerPrefs.GetInt("Toggle Sound")==0){
			yield return new WaitForSeconds(0.2f);
			PlayerPrefs.SetInt("Toggle Sound",1);
			}else{
			yield return new WaitForSeconds(0.2f);
			PlayerPrefs.SetInt("Toggle Sound",0);}
	}

	IEnumerator waitForBall() {
		if(PlayerPrefs.GetInt("Toggle SecondBall")==1){
			yield return new WaitForSeconds(0.2f);
			PlayerPrefs.SetInt("Toggle SecondBall",0);
		}else{
			yield return new WaitForSeconds(0.2f);
			PlayerPrefs.SetInt("Toggle SecondBall",1);}
	}

	IEnumerator waitForInvincible() {
		if(PlayerPrefs.GetInt("Toggle Invincibility")==1){
			yield return new WaitForSeconds(0.2f);
			PlayerPrefs.SetInt("Toggle Invincibility",0);
		}else{
			yield return new WaitForSeconds(0.2f);
			PlayerPrefs.SetInt("Toggle Invincibility",1);}
	}

	IEnumerator waitForDifficulty() {
		if(PlayerPrefs.GetInt("Toggle Difficulty")==2){
			yield return new WaitForSeconds(0.2f);
			PlayerPrefs.SetInt("Toggle Difficulty",0);
		}else if(PlayerPrefs.GetInt("Toggle Difficulty")==1){
			yield return new WaitForSeconds(0.2f);
			PlayerPrefs.SetInt("Toggle Difficulty",2);
		}else{
			yield return new WaitForSeconds(0.2f);
			PlayerPrefs.SetInt("Toggle Difficulty",1);}
	}
}
