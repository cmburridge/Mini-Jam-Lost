using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehavior : MonoBehaviour
{
    public UnityEvent isTriggered;

    public UnityEvent unTrigger;
    
    public UnityEvent isKeyTriggered;
    private void OnTriggerEnter2D(Collider2D other)
    {
        isTriggered.Invoke();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        unTrigger.Invoke();
    }

    public void CheckForKey(FloatData fd)
    {
        if (fd.value > 0)
        {
            isKeyTriggered.Invoke();
        }
    }

    public void ShakeCam(CinemachineVirtualCamera cam)
    {
        var noise = cam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin> ();
        
        noise.m_AmplitudeGain = 1;
        noise.m_FrequencyGain = 1;    
    }

    public void UnShakeCam(CinemachineVirtualCamera cam)
    {
        var noise = cam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin> ();
        
        noise.m_AmplitudeGain = 0;
        noise.m_FrequencyGain = 0;  
    }
}
