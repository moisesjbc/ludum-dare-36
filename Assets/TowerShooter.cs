using UnityEngine;
using System.Collections;

public class TowerShooter : MonoBehaviour {

	public GameObject towerBullet;
	public GameObject bulletSpawnPoint;
	float shootCooldown = 0.25f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("shootCooldown: " + shootCooldown);
		shootCooldown -= Time.deltaTime;
		if (shootCooldown < 0.0f) {
			GameObject bullet = (GameObject)Instantiate (towerBullet, bulletSpawnPoint.transform.position, Quaternion.LookRotation (transform.up, Vector3.back));
			Debug.Log ("bullet.transform.position: " + bullet.transform.position);
			shootCooldown = 0.25f;
		}
	}
}
