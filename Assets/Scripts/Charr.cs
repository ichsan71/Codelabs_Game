using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charr : MonoBehaviour
{
    public int maxJumps = 2;
    private bool grounded;
    private int jumps;
    public float jumpForce;
    private Animator animator;
    

    private void Start()
    {
        animator = GetComponent<Animator>();
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            this.Jump();
        }
 
        animator.SetBool("isGround", this.grounded);
    }

    private void Jump()
    {
        if (jumps > 0)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            grounded = false;
            jumps = jumps - 1;
        }
        if (jumps == 0)
        {
            return;
        }
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Ground")
        {
            jumps = maxJumps;
            grounded = true;
        }
        if (collider.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit enemy");
            Gm._instance.ShowGameOver();
        }
    }
}
