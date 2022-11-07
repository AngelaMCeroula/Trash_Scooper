using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        ProcessInputs();


    }
    void ProcessInputs()
    {
        //uses Unity's axis input keys "The GetAxis page describes in detail what the axisName for GetAxisRaw means. For example the Horizontal axis is managed by Left and Right, and a and d keys. Other Input Axes can be seen in the Edit->Settings->Input window."
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }


}