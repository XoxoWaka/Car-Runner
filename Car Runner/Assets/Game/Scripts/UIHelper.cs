using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIHelper : MonoBehaviour {

	// Use this for initialization
	public void RestartButton() 
	{
		SceneManager.LoadScene("scene1");
	}
	
	// Update is called once per frame
	public void ExitButton () {
	Application.Quit();
	}
}
