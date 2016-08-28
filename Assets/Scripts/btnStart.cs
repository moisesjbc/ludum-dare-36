using UnityEngine;
using System.Collections;

public class btnStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void StartGame()
	{
		Application.LoadLevel (1);
	}
}