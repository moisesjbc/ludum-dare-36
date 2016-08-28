using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class btnStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void StartGame()
	{
		SceneManager.LoadScene ("main");
	}
}