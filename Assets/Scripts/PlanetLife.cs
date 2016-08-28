using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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

		} else {
			
			//Application.LoadLevel ("");
			SceneManager.LoadScene ("loserMenu");
			Debug.Log ("Aniquilado");
		}
	}
}
