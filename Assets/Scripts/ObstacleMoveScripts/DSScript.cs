using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSScript : MonoBehaviour
{
    public Slide SlideRotation;
    [SerializeField] private Transform startPoint, endPoint;
    public float DSMoveObsSpeed;
    [SerializeField] private PlayerMove MovePlayer;
    public GameObject CmCamera;
    public AudioSource AudioSource;


    private void Awake()
    {
        AudioSource = gameObject.GetComponent<AudioSource>();
        SlideRotation.RotateObstacle += ObstacleRotation;
    }

    
    private void ObstacleRotation(float sd)
    {
        
        if (gameObject.tag=="DownSideObs")
        {
            DSMoveObsSpeed += sd / 500f;
            DSMoveObsSpeed = Mathf.Clamp(DSMoveObsSpeed, 0, 1f);
            transform.position = Vector3.Lerp(startPoint.position, endPoint.position, DSMoveObsSpeed); 
        }


    }
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.enabled = true;
            MovePlayer.canControl = false;
            MovePlayer.LevelFailCanvas.SetActive(true);
            MovePlayer.speed = 0f;
            MovePlayer.animations.enabled = false;
            MovePlayer.enabled = false;
            CmCamera.SetActive(false);
            MovePlayer._audioSource.enabled = false;
            foreach (GameObject rb in MovePlayer.PlayerBody)
            {
                rb.GetComponent<Rigidbody>().isKinematic = false;
            }
            
        }
    }
    
}
