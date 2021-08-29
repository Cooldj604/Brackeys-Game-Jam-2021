using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HighScoreDisplay : MonoBehaviour
{

    public Text highscoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscoreDisplay.text = Math.Round((50 - HighScore.highScore), 2).ToString();
    }
}
