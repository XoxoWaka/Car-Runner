using UnityEngine;
using System.Collections;

public class CarControll : MonoBehaviour {

	public Transform target;
	public Vector3 moveLeftVector;
	public Vector3 moveRightVector;
	public float speed;
	
	void Update () {
	Vector3 movePos = new Vector3(target.position.x,0.18f,-5.71f);
	if(Input.GetKey(KeyCode.A))
	{
	
		if(target.transform.position.x > -2.8f)
		{
			target.transform.Translate(moveLeftVector * Time.deltaTime * speed);
		}	
	}
	if(Input.GetKey(KeyCode.D))
	{
		if(target.transform.position.x < 2.8f)
		{
			target.transform.Translate(moveRightVector * Time.deltaTime * speed);
		}	
	}
	transform.LookAt(target);
	transform.position = Vector3.MoveTowards(transform.position,movePos,Time.deltaTime*(speed-0.5f));
	}
}
