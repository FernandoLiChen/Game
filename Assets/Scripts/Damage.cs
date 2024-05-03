using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public playerHealth pHealth;
    public EnemyHealth eHealth;
 
    public float damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            pHealth.health -= damage;

        }
        if(other.gameObject.CompareTag("Enemy")){
            eHealth.ehealth -= damage;

        }
        if(other.gameObject.CompareTag("BOSS")){
            eHealth.ehealth -= damage;

        }
        
    }

    

    

    
    
}
