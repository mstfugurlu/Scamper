using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    //[SerializeField] private Transform obstacle;
    private Vector2 startTouch, slideDelta, secondTouch;
    //public Action<Transform>RotateObstacle=delegate {  };


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
            Debug.Log(slideDelta);
            
            
        }
        
        
        
        
        
    }
}


