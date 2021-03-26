using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLeben : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    private bool dead;
    public GameObject grabstein; 

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            dead = true;
            Destroy(gameObject);
            PlayerDies();
            
        }
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

    public void PlayerDies()
    {
        Instantiate(grabstein);
        
    }




}
