using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyCreation : MonoBehaviour {
	public float ENEMY_RESPAWN_TIME = 1.0f;
	public float DISTANCE_TO_PLANET = 5.0f;
	float timeUntilNextEnemy;

	List<GameObject> enemyPrefabs = new List<GameObject>();
	public GameObject enemyPrefab1;
	public GameObject enemyPrefab2;
	public GameObject enemyPrefab3;


	// Use this for initialization
	void Start () {
		enemyPrefabs.Add (enemyPrefab1);
		enemyPrefabs.Add (enemyPrefab2);
		enemyPrefabs.Add (enemyPrefab3);
		timeUntilNextEnemy = ENEMY_RESPAWN_TIME;
	}

	void GenerateEnemy(){
		float angle = Random.Range (0.0f, 359.0f);
		Vector3 initialPosition = new Vector3(
			DISTANCE_TO_PLANET * Mathf.Cos(angle),
			DISTANCE_TO_PLANET * Mathf.Sin(angle),
			0.0f
			);
		int prefabIndex = UnityEngine.Random.Range(0,3);
		GameObject newEnemy = (GameObject) Instantiate(enemyPrefabs[prefabIndex], initialPosition, Quaternion.identity);
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
