using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartBehavior : MonoBehaviour
{
    public UnityEvent startBeh;
    void Start()
    {
        startBeh.Invoke();
    }
}
