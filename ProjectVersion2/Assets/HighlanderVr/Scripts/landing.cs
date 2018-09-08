using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landing : MonoBehaviour {

    // Use this for initialization
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
