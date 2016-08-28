using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIStory : MonoBehaviour {

	public Sprite [] dialogSprites;
	public Image dialog;
	int dialogIndex = 0;

	// Use this for initialization
	void Start () {
		dialog.sprite = dialogSprites [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			if (dialogIndex < dialogSprites.Length - 1){
			dialogIndex++;
			dialog.sprite = dialogSprites [dialogIndex];
			} else {
				SceneManager.LoadScene ("main");

		}
	}
}
}
