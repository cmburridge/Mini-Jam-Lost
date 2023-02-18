using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public FloatData speed;
    public GameObject art;

    public GameObject flashLight;
    public bool isOn = true;
    public FloatData power;
    public float amount;
    public GameObject text;

    private float speedmax;
    private float speedmin;

    private void Start()
    {
        speed.value += 1;
        speedmax = speed.value;
        speed.value -= 1;
        speedmin = speed.value;
    }

    public void Boost(float amount)
    {
        speedmax += amount;
        speedmin += amount;
    }
    
    void Update()
    {
        if (power.value != 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isOn == true)
                {
                    speed.value = speedmin;
                    isOn = false;
                    flashLight.SetActive(false);
                }
                else if (isOn == false)
                {
                    text.SetActive(false);
                    speed.value = speedmax;
                    isOn = true;
                    flashLight.SetActive(true);
                }
            }  
        }
        
        if (power.value <= 0)
        {
            speed.value = speedmin;
            isOn = false;
            flashLight.SetActive(false);
        }

        if (isOn == true)
        {
            power.value -= amount * Time.deltaTime;
        }

        art.transform.position = this.transform.position;
        
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
 
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        art.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
 
        //if (rotationZ < -90 || rotationZ > 90)
        {
            if(transform.eulerAngles.y == 0)
            {
                art.transform.localRotation = Quaternion.Euler(180, 0, -rotationZ);
            } 
            else if (transform.eulerAngles.y == 180) 
            {
                art.transform.localRotation = Quaternion.Euler(180, 180, -rotationZ);
            }
        }

        float x = Input.GetAxis("Horizontal");
        Vector3 movementx = new Vector3(x, 0, 0);
        transform.Translate(movementx * speed.value * Time.deltaTime);  
        
        float y = Input.GetAxis("Vertical");
        Vector3 movementy = new Vector3(0, y, 0);
        transform.Translate(movementy * speed.value * Time.deltaTime);
    }
}
