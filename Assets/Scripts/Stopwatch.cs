using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Stopwatch : MonoBehaviour
{
    public TextMeshProUGUI currentTimeText;
    public CurrentRecordKeeper currentRecord;

    float currentTime = 0;
    [SerializeField] bool isActive = true;

    void Update()
    {
        if (isActive)
        {
            currentTime = currentTime + Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(currentTime);

            currentTimeText.text = "Time Taken: " + time.ToString(@"mm\:ss");
        }
    }

    public void startStopwatch() { isActive = true; }
    public void stopStopwatch() 
    { 
        isActive = false;
        currentRecord.checkIfRecord(currentTime);
    }

    // Returns the current time of the timer
    public float getCurrentTime()
    {
        return currentTime;
    }

    // Returns a filtered time containing only whole seconds
    public int getCurrentSecond()
    {
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        return (int)time.TotalSeconds;
    }
}
