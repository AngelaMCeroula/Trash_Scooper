using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionEvents : MonoBehaviour
{
    
    
    
  // Trigger collision events 
  
    private void OnTriggerEnter2D(Collider2D colTrigger) // When player collides
    {

        if (colTrigger.gameObject.CompareTag("Animal"))
        {
            Debug.Log("wot wot");
            ScoreManager.instance.AddPointAnimal();
            Destroy(colTrigger.gameObject);
            
        }
        
        if (colTrigger.gameObject.CompareTag("Trash"))
        {
            Debug.Log("some more trash");
            //UpdateUI
            ScoreManager.instance.AddPoint();
            Destroy(colTrigger.gameObject);
        }
        
    }
    
    
}
