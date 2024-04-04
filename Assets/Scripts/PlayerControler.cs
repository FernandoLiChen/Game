using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 3f;
    private bool isFacingRight = true;

    public Rigidbody2D rb;
    [SerializeField] private Transform wallCheck;

    public Animator animator;
    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    public void SetMoveSpeed(float newSpeedAdjustment)
    {
        speed += newSpeedAdjustment;
    }

}
