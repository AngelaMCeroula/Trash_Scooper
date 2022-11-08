using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public static TrashSpawner instance;

    public GameObject trash;
    public GameObject moreTrash;

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
            moreTrash = Instantiate(trash, new Vector3(Random.Range(-10.0f, 10.0f),3.5f,0), transform.rotation) as GameObject;
            timer = 0;
        }

    }
}
