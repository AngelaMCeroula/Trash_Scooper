using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPickup : MonoBehaviour
{ 
 /*  use this one for collision!
  
   private void OnCollisionEnter2D(Collision2D collision) // When object collides
    {
        
        if (collision.gameObject.CompareTag("Player")) // if object collides with game objects tagged Player
        {
            Debug.Log("You have picked up some trash");
            
            //UpdateUI
            ScoreManager.instance.AddPoint();
            Destroy(collision.gameObject);
        }
        
    }
*/
    private void OnTriggerEnter2D(Collider2D col) // when object enters trigger box
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("TRASH");
            //UpdateUI
            ScoreManager.instance.AddPoint();
            Destroy(gameObject);
        }
            
    }
}
