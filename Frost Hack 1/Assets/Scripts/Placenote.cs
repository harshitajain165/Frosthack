using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class Placenote : MonoBehaviour
{
    private ARRaycastManager rayManager;
    private GameObject visual;

    void Start() {
        //Get Components
        rayManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;

        //Hide Placement visual
        visual.SetActive(false);

    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(index: 0).position;
            return true;
        }
        touchPosition = default;
        return false;

    }

    void Update()
    {
        //Shoot RayCast from centre of screen
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        rayManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);


        //if hit AR Plane, Update position and Rotation
        if(hits.Count > 0){
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;

            if(!visual.activeInHierarchy){
                visual.SetActive(true);
            }
            
        }

        //Hide Placenote after touch
         if(!TryGetTouchPosition(out Vector2 touchPosition))
        return;

        if(rayManager.Raycast(touchPosition,hits,trackableTypes: TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;
            visual.SetActive(false);
        }

        this.enabled = false;

    }
}

