using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class PointerEventsController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int MaxRotation = 360;
    public int RotationSpeed = 1000;
    public ParticleSystem particalSysLeft;
    public ParticleSystem particalSysRight;

    public Rigidbody projectileLeft;            
    public Rigidbody projectileRight;
    public float shotForce = 250f;
    public float moveSpeed = 50f;
 

    public void Start()
    {

        particalSysLeft.Stop();
        particalSysRight.Stop();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
        if (eventData != null)
        {
            Quaternion rotationValue = eventData.pointerEnter.gameObject.transform.rotation;
            Transform transformValue = eventData.pointerEnter.gameObject.transform;
            Vector3 pointValue = eventData.pointerCurrentRaycast.worldPosition;
          
            RotateTowardsAndShoot(transformValue);

        }
    }



    private void RotateTowardsAndShoot(Transform transformValue)
    {

        particalSysLeft.transform.LookAt(transformValue);
        particalSysRight.transform.LookAt(transformValue);


        Rigidbody leftRocket = Instantiate(projectileLeft, particalSysLeft.transform.position, particalSysLeft.transform.rotation) as Rigidbody;
        leftRocket.AddForce(particalSysLeft.transform.forward * shotForce);

        Rigidbody rightRocket = Instantiate(projectileRight, particalSysRight.transform.position, particalSysRight.transform.rotation) as Rigidbody;
        rightRocket.AddForce(particalSysRight.transform.forward * shotForce);

        leftRocket.gameObject.AddComponent(Type.GetType("HitOnTarget"));
        rightRocket.gameObject.AddComponent(Type.GetType("HitOnTarget"));

        particalSysLeft.Play();
        particalSysRight.Play();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
      
    }

}
