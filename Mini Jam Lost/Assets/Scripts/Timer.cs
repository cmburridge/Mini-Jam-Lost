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
        TimerStart();
    }
    
    void TimerStart()
    {
        StartCoroutine(timerTime());
    }

    IEnumerator timerTime()
    {
        while (timeRemaining.value > 0)
        {
            time = timeRemaining.value;
            
            yield return new WaitForSeconds(1);
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
        
        timeRemaining.value += 24 * Time.deltaTime;
        imageFront.fillAmount = timeRemaining.value / timeRemaining.OGValue;
    }
}
