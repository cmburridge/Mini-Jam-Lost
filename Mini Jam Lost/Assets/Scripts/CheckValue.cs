using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckValue : MonoBehaviour
{
    public FloatData fd;
    public float checkAmount;

    public UnityEvent isCheckedTrue;

    public UnityEvent isCheckedFalse;
    private void Update()
    {
        if (fd.value > checkAmount)
        {
            isCheckedTrue.Invoke();
        }
        
        if (fd.value <= checkAmount)
        {
            isCheckedFalse.Invoke();
        }
    }
}
