using UnityEngine;
using System.Collections;

public class TrybPrawy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * (20 * Time.deltaTime));
	}
}
