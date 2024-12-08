using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;
    public TMP_Text healthText;

    public int health = 3;

    public void Awake()
    {
        instance = this;
    }

    public void DecreaseHealth()
    {
        if (health > 0)
        {
            health--;
            //print(health);
            ChangeHealthText();
        }
        if (health <= 0)
        {
            print("You are Dead");
        }
    }

    private void ChangeHealthText()
    {
        healthText.text = "Health : " + health;
    }
}
