﻿using UnityEngine;
using System.Collections;

public class Kamera : MonoBehaviour {

	public float orthographicSize = 5;
	public float aspect = 1.23f;
	
	void Start()
	{

		Camera.main.projectionMatrix = Matrix4x4.Ortho(
			-orthographicSize * aspect, orthographicSize * aspect,
			-orthographicSize, orthographicSize,
			GetComponent<Camera>().nearClipPlane, GetComponent<Camera>().farClipPlane);
	}
	void FixedUpdate(){
				if (Input.GetKeyDown (KeyCode.Escape)) {
				Application.LoadLevel(1);
				}
		}
	}
