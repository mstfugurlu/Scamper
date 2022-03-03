using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSScript : MonoBehaviour
{
    public Slide SlideRotation;
    [SerializeField] private Transform startPoint, endPoint;
    public float DSMoveObsSpeed;
    [SerializeField] private PlayerMove MovePlayer;
    
    private void Awake()
    {
        SlideRotation.RotateObstacle += ObstacleRotation;
    }

    
    private void ObstacleRotation(float sd)
    {
        
        if (gameObject.tag=="DownSideObs")
        {
            DSMoveObsSpeed += sd / 500f;
            transform.position = Vector3.Lerp(startPoint.position, endPoint.position, DSMoveObsSpeed); 
        }


    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            MovePlayer.canControl = false;
            MovePlayer.LevelFailCanvas.SetActive(true);
            MovePlayer.speed = 0f;
            MovePlayer.animations.enabled = false;
            MovePlayer.enabled = false;
            foreach (GameObject rb in MovePlayer.PlayerBody)
            {
                rb.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
    
}
