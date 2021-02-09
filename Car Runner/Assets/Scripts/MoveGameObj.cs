using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGameObj : MonoBehaviour
{
    [SerializeField] private Vector3 moveVector;
    [SerializeField] private float speed;
    [SerializeField] private float timeBeforeDestroy;

    private void Start()
    {
        Destroy(gameObject, timeBeforeDestroy);
    }
    private void Update()
    {
        transform.Translate(moveVector * speed);
    }
}
