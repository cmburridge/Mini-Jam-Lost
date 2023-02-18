using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image imageFront;

    public FloatData timeRemaining;

    public float time;

    public UnityEvent Timer0;

    public float amount;
    void Start()
    {
        time = 1;
        TimerStart();
    }
    
    public void TimerStart()
    {
        StartCoroutine(timerTime());
    }

    public void resetTimer()
    {
        time = 2;
        StartCoroutine(timerTime());
    }

    IEnumerator timerTime()
    {
        while (timeRemaining.value > 0)
        {
            time = timeRemaining.value;
            
            yield return new WaitForSeconds(time);
            timeRemaining.value -= amount * Time.deltaTime;
            imageFront.fillAmount = timeRemaining.value / timeRemaining.OGValue;
        }

        if (timeRemaining.value < 0)
        {
            Timer0.Invoke();
        }
    }

    public void IncreaseTime()
    {
        time = timeRemaining.value;
        timeRemaining.value = timeRemaining.OGValue;
        imageFront.fillAmount = timeRemaining.value / timeRemaining.OGValue;
    }
}
