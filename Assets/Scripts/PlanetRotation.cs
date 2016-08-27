using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {

	public float rotationSpeed = 50.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0.0f, 0.0f, rotationSpeed * Time.deltaTime);
		}else if(Input.GetKey (KeyCode.D)){
			transform.Rotate (0.0f, 0.0f, -rotationSpeed * Time.deltaTime);
		}
		*/
		transform.Rotate (0.0f, 0.0f, rotationSpeed * Time.deltaTime);
	}
}
