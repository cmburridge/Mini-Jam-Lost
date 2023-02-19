using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Events;

public class EnemyAi : MonoBehaviour
{
    public float speed;
    public GameObject target;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    public void SetTarget(GameObject obj)
    {
        target = obj;
        this.transform.LookAt(target.transform.position, Vector3.forward);
    }

    public void ResetTarget(GameObject obj)
    {
        target = obj;
        this.transform.LookAt(target.transform.position, Vector3.forward);
        this.transform.position = obj.transform.position;
    }
}
