using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehavior : MonoBehaviour
{
    public UnityEvent isTriggered;

    public UnityEvent isKeyTriggered;
    private void OnTriggerEnter2D(Collider2D other)
    {
        isTriggered.Invoke();
    }

    public void CheckForKey(FloatData fd)
    {
        if (fd.value > 0)
        {
            isKeyTriggered.Invoke();
        }
    }
}
