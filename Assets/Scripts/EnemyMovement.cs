using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public GameObject planet;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		planet = GameObject.Find("Planet");
		float xSpin = Random.Range(0,360);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 enemyToPlanetDirection = planet.transform.position - transform.position;
		gameObject.transform.Translate (speed * Vector3.Normalize (enemyToPlanetDirection) * Time.deltaTime);
		//transform.Rotate (0.0f, 0.0f, 1.0f);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Planet") {
			Destroy (gameObject);
		}
	}
}
