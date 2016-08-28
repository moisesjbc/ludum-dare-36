using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class btnStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//SceneManager.LoadScene ("dialogs");
	}

	public void StartGame()
	{
		SceneManager.LoadScene ("dialogs");
	}
}