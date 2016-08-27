﻿using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {
	
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(startPos,transform.position);
		transform.position += Vector3.Normalize (transform.localPosition);

		if(distance >=8)
		{
			Destroy(gameObject);
		}	 
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}
}