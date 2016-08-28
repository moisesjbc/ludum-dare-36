using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlanetLife : MonoBehaviour {

	int health = 3;
	public Slider healthBar;

	// Use this for initialization
	void Start () {
	
	}
		
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		health--;
		if (health >= 0) {
			healthBar.value = health;	
			Debug.Log ("LIFE: " + health);
		}
		else
		Debug.Log ("Aniquilado");
		
	}
}
