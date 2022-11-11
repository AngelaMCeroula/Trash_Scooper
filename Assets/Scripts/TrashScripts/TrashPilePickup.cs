using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPilePickup : MonoBehaviour
{
    
    public AudioClip trashSound;
    
    private void OnTriggerEnter2D(Collider2D col) // when object enters trigger box
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("BIG TRASH");
            //UpdateUI
            ScoreManager.instance.AddPointPile();
            AudioSource.PlayClipAtPoint(trashSound, transform.position);
            Destroy(gameObject);
        }
            
    }
}
