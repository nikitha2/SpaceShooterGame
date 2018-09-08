using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShipMovementScript : MonoBehaviour {

    public GameObject player;
    public GameObject endPoint;
    public int timeCounter;

    void Start()
    {

        rocketMovement();
    }

    private void rocketMovement()
    {
        iTween.MoveTo(player,
            iTween.Hash(
                "position", endPoint.transform.position,
                "time", 205,
                "easetype", "linear"
            )
        );
    }


}
