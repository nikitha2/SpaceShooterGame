using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorRotation : MonoBehaviour {

    public float speed = 45f;

    private void Update()
    {
       
        transform.Rotate(Vector3.up,speed*Time.deltaTime);

    }

}







/*using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class MeteorRotation : MonoBehaviour {

    bool noTarget = true;
    float speed = 15.5f;
    float rotateSpeed = 1.5f;
    float timer = 0.0f;
    Quaternion qTo;

    void Start()
    {
        qTo = Quaternion.Euler(0, Random.Range(-180, 180), 0);
       
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (noTarget == true)
        {    
            if (timer > 2)
            { 
                qTo = Quaternion.Euler(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));
                timer = 0.0f;
            }
            transform.rotation = Quaternion.Slerp(transform.rotation, qTo, Time.deltaTime * rotateSpeed);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

}
*/
