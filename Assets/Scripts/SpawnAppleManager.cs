using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAppleManager : MonoBehaviour
{
    //public Transform[] spawnPoint;
    public GameObject applePrefab;
    //public float spawnDelay;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnApple();
        }
    }
    public void SpawnApple()
    {
        Instantiate(applePrefab, transform.position, Quaternion.identity);
    }

}
