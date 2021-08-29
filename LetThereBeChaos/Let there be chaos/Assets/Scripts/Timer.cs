using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeValue = 50;
    public Text timer;

    // Update is called once per frame
    public void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            FindObjectOfType<GameManager>().EndGame();
        }

        DisplayTime(timeValue);
        Debug.Log(timeValue);

    }

    public void DisplayTime(float timeToDisplay)
    {

        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        timer.text = (Mathf.Round(timeValue).ToString());
    }

    public void endingScore()
    {
        if (HighScore.highScore < timeValue)
        {
            HighScore.highScore = timeValue;
        }
    }

}
