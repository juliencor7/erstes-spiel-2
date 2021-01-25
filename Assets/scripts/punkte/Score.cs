using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   public int score;
    public static Score instance;

    void Start()
    {

        instance = this;


    }
    

  
    void Update()
    {
        



    }

    public void PunkteAddieren(int scoreAdd)
    {

        score += scoreAdd;

        

    }



    









}
