using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    Animator animator;
    bool jump;
    public float jumpPower =50;
    float horizontalValue;
    public LayerMask groundLayer;

    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
      animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, 2f, groundLayer);
        Debug.DrawLine(transform.position, transform.position + -transform.up, Color.red);
        if (hit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (isGrounded)
        {
            if (Input.GetButtonDown("jump"))
            {
                rb.AddForce(Vector3.up * jumpPower);
            }
        }
    }


     private void OnTriggerEnter2D(Collider2D other)
     {
       if(other.gameObject.CompareTag("Coins"))
       {
         Destroy(other.gameObject);
       }
 
     }
}
