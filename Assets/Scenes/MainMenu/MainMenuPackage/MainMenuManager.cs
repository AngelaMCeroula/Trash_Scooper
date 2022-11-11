using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("insert game scene name here!")]
    public string mainGameSceneName;

    public void ScenePlayDelay()
    {
        SceneManager.LoadScene(mainGameSceneName);
    }
    
    public void SceneQuitDelay()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        Invoke(nameof(ScenePlayDelay), 0.5f);
    }

    public void QuitGame()
    {
        Invoke(nameof(SceneQuitDelay), 0.5f);
        Debug.Log("You QUIT the game!");
    }

}
