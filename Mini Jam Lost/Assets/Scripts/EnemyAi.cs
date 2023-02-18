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
    }
}
