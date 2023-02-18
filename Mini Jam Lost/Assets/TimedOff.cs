using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimedOff : MonoBehaviour
{
    public UnityEvent timedOff;
    public float time;
    
    private void Start()
    {
        StartCoroutine(Off());
    }

    IEnumerator Off()
    {
        yield return new WaitForSeconds(time);
        timedOff.Invoke();
    }
}
