using UnityEngine;
using System.Collections;

public class GraczPoziom : MonoBehaviour {
		
		Ray ray = new Ray ();
	RaycastHit hit = new RaycastHit();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetMouseButton(0))
		{
			ray= Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit))
			{
				Vector2 temp = transform.position;
				temp.x = hit.point.x;
				gameObject.transform.position=temp;
			}

		}
	}
	void FixedUpdate(){
		if (Death.gameOver == true) {
			GetComponent<Renderer>().enabled = false;		
		} else {
			GetComponent<Renderer>().enabled = true;
		}
	}
}
