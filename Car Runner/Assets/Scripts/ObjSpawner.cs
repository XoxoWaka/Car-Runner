using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
    [SerializeField] private bool isSameDelay;
    [SerializeField] private bool isRandomObject;
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private GameObject[] objectsToSpawn;
    [SerializeField] private float timeBeforeSpawn;
    [SerializeField] private float spawnDelay;
    [SerializeField] private float minDelay;
    [SerializeField] private float maxDelay;


    private void Start()
    {
        if (isSameDelay)
        {
            InvokeRepeating("Spawn", timeBeforeSpawn, spawnDelay);
        }
        else
            StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        Spawn();        
    }

    private void Spawn()
    {
        if (!isRandomObject)
        {
            GameObject obj = Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
        if ( isRandomObject)
        {
            GameObject obj = Instantiate(objectsToSpawn[Random.Range(0,objectsToSpawn.Length)], transform.position, transform.rotation);
        }
        if (!isSameDelay)
        {
            StartCoroutine(Spawner());
        }


    }

}
