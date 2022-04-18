using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class RoadDownAreaTrigger : MonoBehaviour
{
    [SerializeField] private PlayerMove MovePlayer;
    public GameObject CmCamera;
   // public AudioSource AudioSource;
    public GameObject RoadCreator;
    [SerializeField] private GameObject camera;
  


    private void OnCollisionEnter(Collision collision)
    {
        
        
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                
                MovePlayer.canControl = false;
                MovePlayer.LevelFailCanvas.SetActive(true);
                MovePlayer.speed = 0f;
                MovePlayer.animations.enabled = false;
                MovePlayer.enabled = false;
                CmCamera.SetActive(false);
                MovePlayer._audioSource.enabled = false;
                camera.GetComponent<ParentConstraint>().enabled = false;
                foreach (GameObject rb in MovePlayer.PlayerBody)
                {
                    rb.GetComponent<Rigidbody>().isKinematic = false;
                    
                }
                RoadCreator.SetActive(false);
              
            }
        }
        
    }
}
