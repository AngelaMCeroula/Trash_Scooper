using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
     
    private void Score(Collision2D collision)
    {   
        if(collision.transform.tag == "Score")
        {
           
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           AudioManager.instance.Play("GameOver");
        }
    }
}