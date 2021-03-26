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




    /* void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {
            TakeDamage(20);
        }

    } */

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Tag: " + collision.transform.tag);
        if (collision.transform.tag == "Enemy")
        {
            Debug.Log("hitted");
            //TODO Gegner vielleicht despawnen mit einem effekt?
            TakeDamage(20);
        } else {
            Debug.Log("Not");
        }
    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void PlayerDies()
    {
        //TODO es fehlen noch koordinaten wo der grabstien gespawnt werden soll
        Instantiate(grabstein);
        
    }
}
