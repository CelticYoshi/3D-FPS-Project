using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 180f;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timerText;
    
    private Vector3 _startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        //timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerIsRunning)
        {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            timeRemaining = 0;
            timerIsRunning = false;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);    
    }

    void StartGameTimer()
    {
        timerIsRunning = true;
    }
}
}

