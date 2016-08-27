using UnityEngine;
using System.Collections;

public class SpaceshipMovement : MonoBehaviour {
	
	public GameObject projectileShooter;
	public GameObject planet;
	public float deltaMovement = 1000.0f;
	public float angle = 0.0f;
	public Vector3 targetPosition;

	// Use this for initialization
	void Start () {
		transform.LookAt (new Vector3(-100.0f, 0.0f, 0.0f));
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 spaceshipToPlanet = planet.transform.position - transform.position;

		//targetPosition = new Vector3(2.0f * Mathf.Cos (angle), 2.0f * Mathf.Sin (angle), 0.0f);
		//transform.position = Vector3.Lerp (transform.position, targetPosition, Time.deltaTime * 10);
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.RotateAround(Vector3.zero, Vector3.forward, deltaMovement * Time.deltaTime);
			//angle += deltaMovement * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			//angle -= deltaMovement * Time.deltaTime;
			transform.RotateAround(Vector3.zero, Vector3.forward, -deltaMovement * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.Space)) {

			GameObject bullet = (GameObject)Instantiate (projectileShooter,transform.position,Quaternion.identity);


		}
	}
}
