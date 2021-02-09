using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 rightVector;
    [SerializeField] private Vector3 leftVector;
    [SerializeField] private float speed;
    [SerializeField] private bool isRight;
    [SerializeField] private bool isLeft;

    private void Update()
    {
        Vector3 movePos = new Vector3(target.position.x, 9.665f, 15.8f);

        if (isRight)
        {            
            if (target.transform.position.x < 0.75f)
            {
                target.transform.Translate(rightVector * Time.deltaTime * speed);
            }
        }
        if (isLeft)
        {
            if (target.transform.position.x > -4.5f)
            {
                target.transform.Translate(leftVector * Time.deltaTime * speed);
            }
        }

        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, movePos, Time.deltaTime*(speed-0.5f));
    }

    public void TurnLeft(bool isOn)
    {
        isRight = isOn;
    }
    public void TurnRight(bool isOn)
    {
        isLeft = isOn;
    }
}
