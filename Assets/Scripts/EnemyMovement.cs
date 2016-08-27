using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public GameObject planet;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		planet = GameObject.Find("Planet");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 enemyToPlanetDirection = planet.transform.position - transform.position;
		gameObject.transform.Translate (speed * Vector3.Normalize (enemyToPlanetDirection) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Planet") {
			Destroy (gameObject);
		}
	}
}
