using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public GameObject art;

    // Update is called once per frame
    void Update()
    {
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
        transform.Translate(movementx * speed * Time.deltaTime);  
        
        float y = Input.GetAxis("Vertical");
        Vector3 movementy = new Vector3(0, y, 0);
        transform.Translate(movementy * speed * Time.deltaTime);
    }
}
