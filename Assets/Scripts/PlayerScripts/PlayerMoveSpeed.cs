using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveSpeed : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public PlayerControler controler;
    public Animator animator;
    public bool facingRight = true;
    private Rigidbody2D rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        var moveSpeed= Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveSpeed * moveSpeed, rb.velocity.y);

        if (facingRight && moveSpeed< 0)
            Flip();
        else if (!facingRight && moveSpeed > 0)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x = Scaler.x * -1;
        transform.localScale = Scaler;
    }

}
