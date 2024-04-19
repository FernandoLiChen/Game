using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Canvas winCanvas;
    public float ehealth;
    private float maxHealth;


    void Start()
    {
        maxHealth = ehealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (ehealth <= 0)
        {
            winCanvas.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
