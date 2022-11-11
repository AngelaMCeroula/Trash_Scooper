using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPickup : MonoBehaviour
{
    //private bool _animalPicked =false;
    private bool _nearAnimal;

    public AudioClip animalSound;
    
    private void Update()
    {
        if (_nearAnimal && Input.GetKeyDown(KeyCode.E))
        {
            //UpdateUI 
            ScoreManager.instance.AddPointAnimal();
            _nearAnimal = false;
            //_animalPicked = true;
            AudioSource.PlayClipAtPoint(animalSound, transform.position);
            Destroy(gameObject);

        }
    }

    private void OnCollisionEnter2D(Collision2D collisionEnter)
    {
        if (collisionEnter.gameObject.CompareTag("Player"))
        {
         //   Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(),gameObject.CompareTag("Player")GetComponent<Collider2D>());

        }
        
    }
    
    
    private void OnTriggerExit2D(Collider2D triggerExit)
    {
        if (triggerExit.gameObject.CompareTag("Player"))
        {
            _nearAnimal = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D enterTrigger) // when object enters trigger box
    {
        
        if (enterTrigger.gameObject.CompareTag("Player") /*&& _animalPicked == false*/)
        {
            Debug.Log("who-who");
            _nearAnimal = true;
            
        }


       /* if(_animalPicked == true)
        {
            Debug.Log("You picked the animal");
                
        }
        */

    } 
    

}
