using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrashCanScoreMultiplier : MonoBehaviour
{
    public AudioClip trashSound;
    public Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    
    private void OnTriggerEnter2D(Collider2D enterTrigger) // when object enters trigger box
    {
        if(enterTrigger.gameObject.tag == "Player")
        {
            anim.SetBool("Near", true);
            AudioSource.PlayClipAtPoint(trashSound, transform.position);
            ScoreManager.instance.PointMultiplier();
            
            
        }

    }
}


