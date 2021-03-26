using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemy : MonoBehaviour
{

    public GameObject enemy;
    private int counter;
    public int maxCounter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter += 1;
        if (counter >= maxCounter)
        {
            Transform[] childs = (Transform[]) gameObject.GetComponentsInChildren<Transform>();
            GameObject randomObject = (GameObject) ((Transform)childs[Random.Range(0,childs.Length)]).gameObject;
            Instantiate(enemy, randomObject.transform.position, Quaternion.identity);
            counter = 0;
        }

    }
}
