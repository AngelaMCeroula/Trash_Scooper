using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPickup : MonoBehaviour
{
    private bool _animalPicked =false;
    
    
    private void OnTriggerEnter2D(Collider2D col) // when object enters trigger box
    {
        if (col.gameObject.CompareTag("Player") && _animalPicked == false)
        {
            Debug.Log("who-who");
            
            //UpdateUI 
            ScoreManager.instance.AddPointAnimal();
            
            //Destroys this game object (animal)
            //Destroy(gameObject);
            
           _animalPicked = true;
        }
        
         if(_animalPicked == true)
        {
            Debug.Log("You picked the animal");
                
        }
        
        
    }

}
