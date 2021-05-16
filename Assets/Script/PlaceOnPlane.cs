using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.Experimental.XR;
using UnityEngine.UI;
using System;

public class PlaceOnPlane : MonoBehaviour
{
    private ARRaycastManager castManager; 
    private List<ARRaycastHit> hits; 
    public GameObject model;
    public GameObject canvasScan;
    public GameObject canvasMenu;
    private void Start()
    { 
        //obtener los componentes
        castManager = GetComponent<ARRaycastManager>();
        hits = new List<ARRaycastHit>();
        canvasScan.SetActive(true);

        //ocultar la ubicación visual 
        model.SetActive(false);        
        canvasMenu.SetActive(false);
    }
    private void Update()
    {
        //dispara un rayo desde el centro de la pantalla

        if (Input.touchCount == 0)
            return;
        Touch touch = Input.GetTouch(0);

        if (castManager.Raycast(touch.position, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon)&& !IsPointerOverUIObject(touch.position))
        {
            Pose pose = hits[0].pose;
            if (!model.activeInHierarchy)
            {
                model.SetActive(true);
                model.transform.position = pose.position;
                model.transform.rotation = pose.rotation;              

                canvasScan.SetActive(false);
                canvasMenu.SetActive(true);  
            }
        else
            {
            model.transform.position = pose.position;
            }
        }
    }
    bool IsPointerOverUIObject(Vector2 pos)
    {
        if (EventSystem.current == null)
        return false;
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current)
        {
            position = new Vector2(pos.x, pos.y)
        };
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}