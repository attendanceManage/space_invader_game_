using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    public string scorea;
    public float tmpTime = 60;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        timeRemaining = 60;
        scorea = ScoreKeeper.instance.score.ToString();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            scorea = ScoreKeeper.instance.score.ToString();
            if (timeRemaining > 0)
            {
         
                //timeRemaining -= Time.deltaTime;
                timeRemaining = timeRemaining - Time.deltaTime ;
                System.Math.Round(timeRemaining,2);
              // timeRemaining = 60;

                DisplayTime(timeRemaining);
                Debug.Log(Time.deltaTime+" Time "+ timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!"+timeRemaining);
                timeRemaining = 0;
                timerIsRunning = false;
                if(scorea!="270"){
                  SceneManager.LoadScene("LostScreen");
               }
     
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
