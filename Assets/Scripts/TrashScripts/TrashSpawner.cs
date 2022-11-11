using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public static TrashSpawner instance;

    public GameObject trash;
    public GameObject moreTrash;
    public GameObject evenMoreTrash;
    public GameObject evenEvenMoreTrash;

    public float timer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            trash = Instantiate(moreTrash, new Vector3(Random.Range(-8.0f, 194.0f),30f,0), transform.rotation) as GameObject;
            timer = 0;
            
            evenMoreTrash = Instantiate(evenEvenMoreTrash, new Vector3(Random.Range(-8.0f, 194.0f),30f,0), transform.rotation) as GameObject;
            timer = 0;

        }
        
        

    }
}
