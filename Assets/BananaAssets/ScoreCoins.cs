using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCoins : MonoBehaviour
{
    public static ScoreCoins instance;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
                instance = this;
        }
    }
    
    public void ChangeScore(int coinValue)
    {
            score += coinValue;
            text.text = "X" + score.ToString();
    }
  
}
