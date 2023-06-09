using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float timeRemaining = 300;
    public bool timerIsRunning = false;
    public Text timeText;
    private float tasksDone;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        tasksDone = 0;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if(timeRemaining < 0)
        {
            timeRemaining = 0;
            if(tasksDone == 0)
            {
                SceneManager.LoadScene("end");
            }
        }
    }
}
