using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void RestartGame()
	{
		SceneManager.LoadScene ("main");
	}

	public void LoadMainMenu()
	{
		SceneManager.LoadScene ("startmenu");
	}
}
