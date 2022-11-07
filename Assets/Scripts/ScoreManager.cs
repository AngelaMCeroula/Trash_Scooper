using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    
    public TMP_Text scoreText;
    public TMP_Text highscoreText;
    //public TMP_Text ScoreText;
    //public TMP_Text HighsccoreText;
    
    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    { 
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();

    }

    public void AddPoint()
    {
       
        //adds points to the score text, must be referenced on trash items script "ScoreManager.instance.AddPoint();"
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
        
        //saves highscore
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        

    }
    public void AddPointAnimal()
    {
       
        //adds points to the score text, must be referenced on trash items script "ScoreManager.instance.AddPoint();"
        score += 10;
        scoreText.text = score.ToString() + " POINTS";
        
        //saves highscore
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        

    }



}
