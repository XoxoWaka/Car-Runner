using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider boxCollider)
	{
		if(boxCollider.name == "Car")
		{
			SceneManager.LoadScene("scene2");
		}
	}
}
