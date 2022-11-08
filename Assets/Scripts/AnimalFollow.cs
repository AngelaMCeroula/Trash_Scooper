using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalFollow : MonoBehaviour
{
    public bool _animalPicked;
    
    // Start is called before the first frame update
    void Start()
    {
        if (_animalPicked == true)
        {
            Debug.Log("Animal get");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
