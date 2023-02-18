using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void IncreaseFD(float amount)
    {
        value += amount;
    }
    
    public void DecreaseFD(float amount)
    {
        value -= amount;
    }
}
