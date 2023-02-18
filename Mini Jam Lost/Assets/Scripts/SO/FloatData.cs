using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;
    public float OGValue;

    public void IncreaseFD(float amount)
    {
        value += amount;
    }
    
    public void DecreaseFD(float amount)
    {
        value -= amount;
    }

    public void Set0()
    {
        value = 0;
    }

    public void SetOG()
    {
        value = OGValue;
    }
}
