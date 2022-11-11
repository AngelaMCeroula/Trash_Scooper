using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        AudioManager.instance.Play("Button");
    }

    public void QuitGame ()
    {
        Application.Quit();
        AudioManager.instance.Play("Button");
    }
}
