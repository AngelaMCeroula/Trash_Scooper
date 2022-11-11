using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FinalScoreManager : MonoBehaviour
{
    public TMP_Text fScoreText;
    public TMP_Text fHighscoreText;
    
    private static int finalScore = 0;
    public static int finalHighscore = 0;

    private void Start()
    {
        finalScore = ScoreManager.score;
        finalHighscore = PlayerPrefs.GetInt("highscore", 0);
    }

    private void Update()
    { 
        fScoreText.text = finalScore.ToString();
        fHighscoreText.text = finalHighscore.ToString();

    }
}

  
