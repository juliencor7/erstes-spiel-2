using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject hitEffect;
    public int damage;
    
    
  void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
        Debug.Log("Col: ", collision.gameObject);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
       Enemy enemy = hitInfo.GetComponent<Enemy>();
        
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
       
        
        Destroy(gameObject);

        





    }









}

