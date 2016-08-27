using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour {

	public float rotationSpeed = 50.0f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);
	}
}
