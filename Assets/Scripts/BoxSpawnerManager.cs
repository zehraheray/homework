using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BoxSpawnerManager : MonoBehaviour
{
    public Transform[] spawnPointOfBox;
    public GameObject boxPrefab;
    public static BoxSpawnerManager instance; //baska scriptlerle paylasabilmek icin

    public void Awake()
    {
        instance = this;
    }


    public void SpawnBox()
    {
        int index = Random.Range(0, spawnPointOfBox.Length);
        Instantiate(boxPrefab, spawnPointOfBox[index].position, Quaternion.identity);
        //BoxSpawnerManager.instance.SpawnBox();
    }
}
