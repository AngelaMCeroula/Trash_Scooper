using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalFollow : MonoBehaviour
{
    public bool _animalPicked;
    public float speed;
    private GameObject player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        if (_animalPicked == true)
        {
            Debug.Log("Animal get");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        
    }
}
