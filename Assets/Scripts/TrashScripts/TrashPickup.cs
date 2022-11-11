using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPickup : MonoBehaviour
{ 

    public AudioClip trashSound;
  
    
    
    private void OnTriggerEnter2D(Collider2D col) // when object enters trigger box
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("TRASH");
            //UpdateUI
            ScoreManager.instance.AddPoint();
            AudioSource.PlayClipAtPoint(trashSound, transform.position);
            Destroy(gameObject);
        }
            
    }
}
