using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    //private void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
    //        TakeDamage();
    //    }
    //}

    //private void TakeDamage()
    //{
    //    currentHealth--;
    //    healthBar.SetHealth(currentHealth);
    //}
}
