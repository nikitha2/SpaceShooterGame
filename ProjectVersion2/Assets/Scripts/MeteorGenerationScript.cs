using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerationScript : MonoBehaviour {

    private Vector3 positionOfGeneration;
    public GameObject meteorPrefab;
    public GameObject GenerationPoint;
    public float timeCounter = 0;
    public int intTime;
    private int meteorCount = 0;
	
    void Start ()
    {
        
        //meteorPrefab = GameObject.Find("Meteor Parent");
    }
    void Update () {

        intTime = (int)Time.time;
        timeCounter += Time.deltaTime;
        Debug.Log(intTime);

        if (timeCounter < 30)
        {
            if (intTime % 6 == 0)    // use modulo operation for flactuating emissions
            { 
                if(meteorCount <= 30)
                {
                    positionOfGeneration = new Vector3(UnityEngine.Random.Range(GenerationPoint.transform.position.x - 60, GenerationPoint.transform.position.x + 60), UnityEngine.Random.Range(GenerationPoint.transform.position.y - 60, GenerationPoint.transform.position.y + 60), GenerationPoint.transform.position.z);
                    Instantiate(meteorPrefab, positionOfGeneration, Quaternion.identity);
                    meteorCount++;
                }
            }
        }else if(timeCounter >= 30 && timeCounter < 60)
        {
            
        }else if (timeCounter >= 60 && timeCounter < 90)
        {

        }else if (timeCounter >= 90 && timeCounter < 120)
        {

        }else if (timeCounter > 121)
        {

        }
        
	}
}


