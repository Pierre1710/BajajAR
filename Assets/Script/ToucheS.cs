using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ToucheS : MonoBehaviour
{
    #region Cabecera Touch Rotate
    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion rotationY;
    private readonly float rotateSpeedModifier = 0.1f;
    #endregion

    #region Cabecera TouchesScale 
    float initialFingersDistance;
    public GameObject objectTemp;
    Vector3 initialScale;
    #endregion   

    void Update()
    {
        #region TouchRotate
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotateSpeedModifier, 0f);
                transform.rotation = rotationY * transform.rotation;
            }
            #endregion

        #region TouchesScale
            if (Input.touches.Length == 2)
            {
                //Almacena ambos touch
                Touch touchZero = Input.touches[0];
                Touch touchOne = Input.touches[1];
                if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
                {
                    initialFingersDistance = Vector2.Distance(touchZero.position, touchOne.position);
                    initialScale = objectTemp.transform.localScale;
                }
                else if (touchZero.phase == TouchPhase.Moved || touchOne.phase == TouchPhase.Moved)
                {
                    var currentFingersDistance = Vector2.Distance(touchZero.position, touchOne.position);
                    var scaleFactor = currentFingersDistance / initialFingersDistance;
                    objectTemp.transform.localScale = initialScale * scaleFactor;
                }
            }
            #endregion


        }
    }
}