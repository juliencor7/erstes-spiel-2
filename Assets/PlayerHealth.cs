﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("col enter");
        if (collision.CompareTag("Enemy")) 
        {
            Debug.Log("Enemy beruehrt");
            TakeDamage(20);
            
        }
        
        
    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
