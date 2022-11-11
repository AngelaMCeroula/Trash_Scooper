using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    // Thank you Assad for this beautiful player controller script
    
    private Rigidbody2D _rb;
    public float moveSpeed;
    public float jumpForce;
    private bool _isGrounded;
    private bool _isTouchingWall;
    private Vector2 moveDirection;
    private float _yVector;
    

    //This script also has a very primitive form of wall jumping

    void Start()
    {
        //Lets get our rigidbody component and let us know we sucessfully got it using the console
        _rb = GetComponent<Rigidbody2D>();
        Debug.Log("We got the " + _rb);
    }

    void Update()
    {
        //i find it easier to reference the rigidbody2d's velocity in the up and direction as a separate variable
        _yVector = _rb.velocity.y;
        //this calls the method ProcessInputs()
        ProcessInputs();

        //this checks if the user has pressed the space bar and runs the method Jump()
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        
    }

    void FixedUpdate()
    {
        //Fixed update is not tied to the performance of the game, so is great when
        Move();
    }

    void ProcessInputs()
    {
        //this declars a local variable which gets the input of the player
        float moveX = Input.GetAxisRaw("Horizontal");

        //this creates a vector2 for us to use from our two float values
        moveDirection = new Vector2(moveX, _yVector);
    }

    void Jump()
    {
        
        
        
        //we need to check if the player is touching the ground
        if (_isGrounded)
        {
            //this adds our jump force to the up direction for our rigid body
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //we need to set that the player is no longer touching the ground since they are jumping
           // _isGrounded = false;
        }
        if(_isTouchingWall)
        {
            //this does exactly the same thing as the code above accept it reduces it drastically the jumpforce
            _rb.AddForce(Vector2.up * jumpForce/5, ForceMode2D.Impulse);
            _isTouchingWall = false;
            
            
        }
    }

    void Move()
    {
        //this applies the horizontal movement to our player
        _rb.velocity = new Vector2(moveDirection.x * moveSpeed, _yVector);
    }

    
    
    
       private void OnCollisionExit2D(Collision2D collisionExit)
        {
            if (collisionExit.gameObject.CompareTag("Ground"))
            {
                _isGrounded = false;
            }
            
        }
      private void OnCollisionEnter2D(Collision2D collision)
        {
            //this checks if the object is touching the ground by using the tags system
            if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Trash") || collision.gameObject.CompareTag("Animal"))
            {
                Debug.Log("We hit the ground");
                _isGrounded = true;
            }
            //this does the exactly same thing but for walls
            if(collision.gameObject.CompareTag("Wall"))
            {
                _isTouchingWall = true;
            }
    
        } 
      
    
}





