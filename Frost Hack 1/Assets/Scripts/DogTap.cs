using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class DogTap : MonoBehaviour
{
    public GameObject Dog;

    //private GameObject spawnedDog;
    private ARRaycastManager arRaycastManger;
    private Vector2 touchPosition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private void Awake()
    {
        arRaycastManger = GetComponent<ARRaycastManager>();

    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 1)
        {
            touchPosition = Input.GetTouch(index: 0).position;
            return true;
        }
        touchPosition = default;
        return false;

    }
    
    void Update()
    {
        if(!TryGetTouchPosition(out Vector2 touchPosition))
        return;

        if(arRaycastManger.Raycast(touchPosition,hits,trackableTypes: TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;

            Dog.transform.position = hitPose.position;
           /*  if(Dog == null)
            {
                Dog = Instantiate(Dog,hitPose.position,hitPose.rotation);
            }
            else
            {
                Dog.transform.position = hitPose.position;
                
            }

            if(spawnedDog == null)
            {
                spawnedDog = Instantiate(Dog,hitPose.position,hitPose.rotation);
            }
            else
            {
                spawnedDog.transform.position = hitPose.position;
                spawnedDog.transform.rotation = hitPose.rotation;
            }*/

        }
    }
}
