using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ValueCheck : MonoBehaviour
{
    public FloatData fd;
    public float expectedValue;

    public bool isGood;

    public UnityEvent valueEvent;
    private void Update()
    {
        if (fd.value <= expectedValue)
        {
            valueEvent.Invoke();
        }
    }

    public void CheckGood()
    {
        isGood = true;
    }
}
