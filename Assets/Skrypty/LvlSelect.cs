using UnityEngine;
using System.Collections;

public class LvlSelect : MonoBehaviour {
	Ray ray = new Ray ();
	RaycastHit hit = new RaycastHit();
	void Update () {

		if(Input.GetMouseButton(0))
		{
			ray= Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit))
			{
				if (hit.transform.name=="1stlvlButton")
				{
					Application.LoadLevel(4);	
				}
				if (hit.transform.name=="2ndlvlButton")
				{
					Application.LoadLevel(5);
				}
				if (hit.transform.name=="3rdlvlButton")
				{
					Application.LoadLevel(6);
				}
				if (hit.transform.name=="4thlvlButton")
				{
					Application.LoadLevel(7);
				}
				if (hit.transform.name=="5thlvlButton")
				{
					Application.LoadLevel(8);
				}
				if (hit.transform.name=="ReturnButton")
				{
					Application.LoadLevel(1);
				}
			}
			
		}
	}
}
