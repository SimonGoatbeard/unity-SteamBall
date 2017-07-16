using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {
	Ray ray = new Ray ();
	RaycastHit hit = new RaycastHit();

	void Update () {
		if(Input.GetMouseButton(0))
		{
			ray= Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit))
			{
				if (hit.transform.name=="PlayButton")
				{
					Application.LoadLevel(2);	
				}
				if (hit.transform.name=="ExitButton")
				{
					Application.Quit();	
				}
				if (hit.transform.name=="CreditsButton")
				{
					Application.LoadLevel(3);
				}
				if (hit.transform.name=="ScoreBoardButton")
				{
					Application.LoadLevel(9);	
				}
				if (hit.transform.name=="OptionsButton")
				{
					Application.LoadLevel(10);	
				}
			}
			
		}
	}
}
