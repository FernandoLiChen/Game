using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float ehealth;
    private float maxHealth;


    void Start()
    {
        maxHealth = ehealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(ehealth <= 0){
            Destroy(gameObject);
        }
    }
}
