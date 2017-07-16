using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {
	public Vector3 Exitbutton;
	public Vector3 Exitbuttoniddle;
	Ray ray = new Ray ();
	RaycastHit hit = new RaycastHit();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Death.gameOver == true) {
						transform.position = Exitbutton;
				} else {
			transform.position = Exitbuttoniddle;	
		}


		if(Input.GetMouseButton(0))
		{
			ray= Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit))
			{
				if (hit.transform.name=="Return")
				{
					Application.LoadLevel(1);	
				}
			}
			
		}
	}
}
