using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBuff : MonoBehaviour
{
    public float amount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerHealth phealth = collision.GetComponent<playerHealth>();
        if (phealth != null)
        {
            phealth.Heal(amount);
            Destroy(gameObject);
        }
    }
}
