using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrbasteinErscheint : MonoBehaviour
{

    public GameObject grabsteinPrefab;
    public GameObject grabsteinErzeugen;



    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.tag.Equals("Enemy"))
        {
            PlayerDies();


        }




    }

    void PlayerDies()
    {
        GameObject grabstein = Instantiate(grabsteinPrefab);
    }
}
