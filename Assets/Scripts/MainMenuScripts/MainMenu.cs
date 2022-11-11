using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
       
        AudioManager.instance.Play("Button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
   


    public void QuitGame ()
    {
        Application.Quit();
        AudioManager.instance.Play("Button");
    }
}
