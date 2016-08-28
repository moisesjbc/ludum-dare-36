using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {
	
	private Vector3 startPos;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(startPos,transform.position);
		transform.position += Vector3.Normalize (transform.forward) * speed * Time.deltaTime;

		if(distance >=8)
		{
			Destroy(gameObject);
		}	 
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}