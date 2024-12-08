using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score = 0;
    public void OnTriggerEnter(Collider other)
    {
        //print("Elma sepete girdi");

        if (other.CompareTag("Apple"))
        {
            score++;
            scoreText.SetText(score.ToString());
            Destroy(other.gameObject);
            BoxSpawnerManager.instance.SpawnBox();
            
        }

    }
}
