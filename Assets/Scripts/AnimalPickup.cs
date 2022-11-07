using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPickup : MonoBehaviour
{
    private bool _Animalpicked;
    
    private void OnTriggerEnter2D(Collider2D col) // when object enters trigger box
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("whowho");
            //UpdateUI
            ScoreManager.instance.AddPointAnimal();
            Destroy(gameObject);
            
            _Animalpicked = true;
           
            if(_Animalpicked == true)
            {
                Debug.Log("You picked the animal");
                
            }
            
        }
        
    }

}
