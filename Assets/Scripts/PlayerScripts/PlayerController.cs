using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float moveSpeed;
    public float jumpForce;
    private Vector2 moveDirection;
    private float _yVector;
    private bool isGrounded;
    
    
    public Animator anim;
    
    public bool _facingRight = true;
   
    private float moveInput;

    public AudioClip playerJump;
    
    public AudioClip playerwalk;
    

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    
    void Update()
    {

       // _yVector = _rb.velocity.y;
        
        ProcessInputs();
        Jump();
        
        if(_rb.velocity.y == 0) //ESSENTIAL
        {
            isGrounded = true;
            
            anim.SetBool("isRunning", false);
        }

        if  (_rb.velocity.y == 0 && isGrounded == true && _rb.velocity.x == 0)
        {
            anim.SetBool("isRunning", false);
        }

        if (_rb.velocity.y != 0 && isGrounded == true)
        {
            anim.SetBool("isRunning", true);
            Debug.Log("this should be running");
        } 
  }
  
  void FixedUpdate()
  {
      Move();
      if (_facingRight && moveDirection.x < 0)
          Flip();
      else if (!_facingRight && moveDirection.x > 0)
          Flip();
      
      
  }
  
  void ProcessInputs()
  {
      float moveX = Input.GetAxisRaw("Horizontal");
      
    /*  if (isGrounded == true && moveDirection.x != 0)
      {
          AudioSource.PlayClipAtPoint(playerwalk, transform.position);
          
      }*/
    
      
      moveDirection = new Vector2(moveX, _yVector);
  }
  void Move()
  {
      _rb.velocity = new Vector2(moveDirection.x * moveSpeed, _rb.velocity.y);
      
  }

 
 
 void Jump()
 {
     if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
     {
         _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
         isGrounded = false;
         AudioSource.PlayClipAtPoint(playerJump, transform.position);
         Debug.Log("NO JUMPING FOR YOU!" + isGrounded);
     }

 }

 private void OnCollisionEnter2D(Collision2D col)
 {
     if(!isGrounded)
     {
         Debug.Log("WE CAN JUMP!");

         if (col.gameObject.CompareTag("Ground") || col.gameObject.CompareTag("Trash") || col.gameObject.CompareTag("Animal"))
         {
             isGrounded = true;
             Debug.Log("ISGROUNDED IS TRUEEEEEE!");
         }
     }
 }

 void Flip()
 {
     _facingRight = !_facingRight;
     Vector3 Scaler = transform.localScale;
     Scaler.x = Scaler.x * -1;
     transform.localScale = Scaler;
 }
 
}    
      
  

  

