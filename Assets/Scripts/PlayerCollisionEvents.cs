using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionEvents : MonoBehaviour
{
  
    private void OnCollisionEnter2D(Collision2D collision) // When player collides
    {
        if (collision.gameObject.tag == "Trash") // if player collides with game objects tagged Trash
        {
            Debug.Log("You have picked up some trash");
            //UpdateUI
            ScoreManager.instance.AddPoint();
        }
            
    }
    
}
