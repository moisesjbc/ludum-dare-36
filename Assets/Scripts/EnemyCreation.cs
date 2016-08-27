using UnityEngine;
using System.Collections;

public class EnemyCreation : MonoBehaviour {
	public float ENEMY_RESPAWN_TIME = 1.0f;
	public float DISTANCE_TO_PLANET = 5.0f;
	float timeUntilNextEnemy;
	public GameObject enemyPrefab;

	// Use this for initialization
	void Start () {
		timeUntilNextEnemy = ENEMY_RESPAWN_TIME;
	}

	void GenerateEnemy(){
		float angle = Random.Range (0.0f, 359.0f);
		Vector3 initialPosition = new Vector3(
			DISTANCE_TO_PLANET * Mathf.Cos(angle),
			DISTANCE_TO_PLANET * Mathf.Sin(angle),
			0.0f
			);
		GameObject newEnemy = (GameObject) Instantiate(enemyPrefab, initialPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		timeUntilNextEnemy -= Time.deltaTime;
		if (timeUntilNextEnemy < 0.0f) {
			GenerateEnemy ();
			timeUntilNextEnemy = ENEMY_RESPAWN_TIME;
		}
	}
}
