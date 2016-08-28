using UnityEngine;
using System.Collections;

public class Heno : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.Normalize (transform.forward) * Time.deltaTime;
		float distance = Vector3.Distance (Vector3.zero, transform.position);
		if(distance >=50)
		{
			Destroy(gameObject);
		}	
	}
}
