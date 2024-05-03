using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;

    public float force;
    public float angleOffset = 30f; // Angle offset for each bullet in the spread pattern

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        // Calculate direction towards the player
        Vector3 direction = player.transform.position - transform.position;

        // Add angle offset to the direction
        direction = Quaternion.Euler(0, 0, angleOffset) * direction;

        // Apply force in the modified direction
        rb.velocity = direction.normalized * force;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<playerHealth>().health -= 10;
            gameObject.SetActive(false);
        }
    }
}
