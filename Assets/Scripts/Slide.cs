using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    //[SerializeField] private Transform obstacle;
    private Vector2 startTouch, slideDelta, secondTouch;
    public Action<Transform>RotateObstacle;

    

    private void Start()
    {
    }

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
            //Debug.Log(slideDelta);
            transform.Rotate(0,0,slideDelta.x/5);
                     // transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0,slideDelta.x), 0.2f);
                     Vector3 rotationVector = new Vector3(0, 0, slideDelta.x);
                     Quaternion rotation=Quaternion.Euler(rotationVector);
            
        }
        
        
        
        
        
    }
}


