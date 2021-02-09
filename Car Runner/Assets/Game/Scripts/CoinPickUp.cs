using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinPickUp : MonoBehaviour {

	public Text coinsCount;
	// Use this for initialization
	void Start () {
	 coinsCount = GameObject.Find("CoinsCount").GetComponent<Text>();
	}
	void OnTriggerEnter(Collider coinCollider)
	{
		if(coinCollider.name == "Car")
		{
			coinsCount.text = (int.Parse(coinsCount.text)+1).ToString(); 
			Destroy(gameObject);
		}
	}
}
