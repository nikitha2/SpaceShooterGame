using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMove : MonoBehaviour {
    public GameObject SpaceShip;
    public GameObject startPoint, playPoint;

    // Use this for initialization
   public  void Start () {
        SpaceShip = SpaceShip.transform.parent.gameObject;
        SpaceShip.transform.position = startPoint.transform.position;
        iTween.MoveTo(SpaceShip,
            iTween.Hash(
                "position", playPoint.transform.position,
                "time", 5,
                "easetype", "linear"
            )
        );
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
