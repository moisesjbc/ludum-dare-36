using UnityEngine;
using System.Collections;

public class TowerShooter : MonoBehaviour {

	public GameObject towerBullet;
	public GameObject bulletSpawnPoint;
	public float minShootdownCooldown = 1.0f;
	public float maxShootdownCooldown = 2.0f;
	float shootCooldown;

	// Use this for initialization
	void Start () {
		shootCooldown = Random.Range(minShootdownCooldown, maxShootdownCooldown);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("shootCooldown: " + shootCooldown);
		shootCooldown -= Time.deltaTime;
		if (shootCooldown < 0.0f) {
			GameObject bullet = (GameObject)Instantiate (towerBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation /*Quaternion.LookRotation (transform.up, Vector3.back)*/);
			Debug.Log ("bullet.transform.position: " + bullet.transform.position);
			shootCooldown = Random.Range(minShootdownCooldown, maxShootdownCooldown);
		}
	}
}
