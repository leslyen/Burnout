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
    public Text timeText, EndDetails;
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
                string currentSceneName = SceneManager.GetActiveScene().name;

                switch(currentSceneName){
                case "Home":
                    EndDetails.text = "You ran out of time, did not finish your tasks, and decided to go for a LOOOONG walk until you reached your friends house and have been crashion on their couch since";
                    SceneManager.LoadScene("end");
                    break;
                case "School":
                    EndDetails.text = "School time is so weird, time goes by so slow then BOOM your out of time and have not done your homeowrk or studied for any of your tests, this school thing is not for you";
                    SceneManager.LoadScene("end");
                    break;
                case "Office":
                    EndDetails.text = "working here is a nightmare anyway, so WHAT if you didn't get your tasks done in time, I hear starbucks pays $15 an hour";
                    SceneManager.LoadScene("end");
                    break;
            }
            }
        }
    }
}
