using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehavior : MonoBehaviour
{
    public UnityEvent isTriggered;

    private void OnTriggerEnter2D(Collider2D other)
    {
        isTriggered.Invoke();
    }
}
