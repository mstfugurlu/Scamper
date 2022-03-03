using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorObs : MonoBehaviour
{
    public Slide SlideRotation;
    [SerializeField] private Transform startPoint, endPoint;
    public float DoorMoveObsSpeed;
    private void Awake()
    {
        SlideRotation.RotateObstacle += ObstacleRotation;
    }

    private void ObstacleRotation(float sd)
    {
        if (gameObject.tag == "DownSideObs")
        {
            Debug.Log(sd);
            DoorMoveObsSpeed += sd / 500f;
            Debug.Log(DoorMoveObsSpeed);
            
        }
    }
}
