using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 50f;

    public TMP_Text countdownText;
    void Start()
    {
        currentTime = startingTime;
    }

   
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("FinalScore");
        }

    }
}
