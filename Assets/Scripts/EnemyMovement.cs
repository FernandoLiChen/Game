using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float centerThreshold = 0.1f; // Distance threshold to consider the enemy at the center of the room
    public float minHealthToMove = 50f; // Minimum health to start moving downward
    public Transform centerPoint; // Center point of the room

    private Rigidbody2D rb;
    private bool movingDownward = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Check if health is below the threshold and not already moving downward
        if (GetComponent<EnemyHealth>().ehealth <= minHealthToMove)
        {
            MoveTowardsCenter();
            ActivateCenterBullets();
        }
    }

    private void MoveTowardsCenter()
    {
        Vector2 direction = (centerPoint.position - transform.position).normalized;
        rb.velocity = direction * moveSpeed;

        // Check if enemy reached the center or is close enough
        if (Vector2.Distance(transform.position, centerPoint.position) <= centerThreshold)
        {
            StopMoving(); // Optionally stop at the center or do some action
        }
    }

    private void ActivateCenterBullets()
    {
        // Find the GameObject with the tag "CenterBullets"
        GameObject centerBulletsObject = GameObject.FindGameObjectWithTag("CenterBullets");

        // Activate the object if found
        if (centerBulletsObject != null)
        {
            centerBulletsObject.SetActive(true);
        }
    }

    private void StopMoving()
    {
        rb.velocity = Vector2.zero;
        movingDownward = false;
    }
}
