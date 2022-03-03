using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Slide : MonoBehaviour
{
    
    public Vector2 startTouch, slideDelta, secondTouch;
    public UnityAction <float> RotateObstacle;


   
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startTouch = Input.mousePosition;
        }

       
        if (Input.GetMouseButton(0))
        {
            secondTouch = Input.mousePosition;
            slideDelta = secondTouch - startTouch;
            startTouch = secondTouch; 
            RotateObstacle?.Invoke(slideDelta.x);
            Debug.Log(slideDelta);
        }


    }

   
}